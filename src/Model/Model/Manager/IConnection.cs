using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;

using Model.Data;
using Model.Manager.States;

using System.Diagnostics;
using System.Xml.Linq;
using System.Threading;

namespace Model.Manager
{
    /// <summary>
    /// IConnection Manages the connection.
    /// </summary>
    public class IConnection
    {
        /// <summary>
        /// Konstructor
        /// </summary>
        public IConnection()
        {
            Logins = new List<LoginData>();
            Sockets = new List<Socket>();
        }
        /// <summary>
        /// Öffnet eine Verbindung
        /// </summary>
        /// <param name="dns">DNS String</param>
        /// <param name="port">Port as Integer</param>
        /// <param name="login">Login as LoginData</param>
        /// <see cref="LoginData"/>
        public void openConnection(string dns, int port, LoginData login)
        {
            IPHostEntry ipHostInfo = Dns.Resolve(dns);
            IPAddress ipAdress = ipHostInfo.AddressList[0];
            IPEndPoint remoteEndPoint = new IPEndPoint(ipAdress, port);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            Sockets.Add(socket);
            Logins.Add(login);
            Connect(remoteEndPoint, socket);
        }
        /// <summary>
        /// Soll die Verbindung schließen.
        /// Benötigt Login, da mehere Sockets offen sein können.
        /// </summary>
        /// <param name="login">Login um die Verbindung von den Anderen Verbindungen zu unterscheiden.</param>
        public void closeConnection(LoginData login)
        {
            int searchedElement;
            for(int i = 0;i<Logins.Count; i++)
            {
                if(login==Logins.ElementAt(i))
                {
                    searchedElement = i;
                }
            }

        }
        // public abstract void sendMessage(LoginData login/*, Message message*/);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="remoteEP"></param>
        /// <param name="client"></param>
        protected static void Connect(EndPoint remoteEP, Socket client)
        {
            client.BeginConnect(remoteEP,
                new AsyncCallback(ConnectCallback), client);

            ConnectDone.WaitOne();
        }
        /// <summary>
        /// Wird bei einem Connect auf den Javver Server ausgeführt.
        /// </summary>
        /// <param name="asyncResult">The result of the Conection</param>
        protected static void ConnectCallback(IAsyncResult asyncResult)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)asyncResult.AsyncState;
                // Complete the connection.
                client.EndConnect(asyncResult);
                Trace.WriteLine("Socket connected to {0}", client.RemoteEndPoint.ToString());
                // Signal that the connection has been made.
                ConnectDone.Set();

                Send(client, "<?xml version='1.0'?>\n<stream:stream xmlns:stream='http://etherx.jabber.org/streams' version='1.0' xmlns='jabber:client' to='" + Logins.ElementAt(Sockets.IndexOf(client)).getDomain() +"' xml:lang='de' xmlns:xml='http://www.w3.org/XML/1998/namespace'>");
                
                Receive(client);
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.ToString());
            }
        }
        /// <summary>
        /// Wird von sendMessage(...) aufgerufen, da erst noch der Socket herausgefunden werden muss und der String erstellt werdem soll.
        /// </summary>
        /// <param name="client"></param>
        /// <param name="data"></param>
        protected static void Send(Socket client, String data)
        {
            // Convert the string data to byte data using ASCII encoding.
            byte[] byteData = Encoding.ASCII.GetBytes(data);

            // Begin sending the data to the remote device.
            client.BeginSend(byteData, 0, byteData.Length, SocketFlags.None,
                new AsyncCallback(SendCallback), client);
        }
        /// <summary>
        /// Ist der Callback von Send.
        /// </summary>
        /// <param name="asyncResult"></param>
        protected static void SendCallback(IAsyncResult asyncResult)
        {
            try
            {
                // Retrieve the socket from the state object.
                Socket client = (Socket)asyncResult.AsyncState;

                // Complete sending the data to the remote device.
                int bytesSent = client.EndSend(asyncResult);
                Trace.WriteLine("Sent {0} bytes to server.", bytesSent.ToString());

                // Signal that all bytes have been sent.
                SendDone.Set();
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.ToString());
            }
        }
        /// <summary>
        /// Wird vom Externen thread aufgerufen, um Nachrichten zu empfangen
        /// </summary>
        /// <param name="client">Socket ist der CLient von dem die Nachricht ausgeht</param>
        protected static void Receive(Socket client)
        {
            try
            {
                // Create the state object.
                StateObject state = new StateObject();
                state.WorkSocket = client;

                // Begin receiving the data from the remote device.
                client.BeginReceive(state.Buffer, 0, state.BufferSize, 0,
                    new AsyncCallback(ReceiveCallback), state);
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.ToString());
            }
        }
        /// <summary>
        /// Wird vom Emfpangsevent aufgerufen.
        /// </summary>
        /// <param name="asyncResult"> Result vom Empfangsevent.</param>
        protected static void ReceiveCallback(IAsyncResult asyncResult)
        {
            try
            {
                // Retrieve the state object and the client socket 
                // from the asynchronous state object.
                StateObject state = (StateObject)asyncResult.AsyncState;
                Socket client = state.WorkSocket;
                // Read data from the remote device.
                int bytesRead = client.EndReceive(asyncResult);
                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.
                    state.SB.Append(Encoding.ASCII.GetString(state.Buffer, 0, bytesRead));
                    if (state.SB.Length > 1)
                    {
                        Monitor.Enter(ResultManager);
                        //ResultManager.reciveXmlMessage(state.SB.ToString());
                        Trace.Write(state.SB.ToString());
                        Monitor.Exit(ResultManager);
                    }
                    // Signal that all bytes have been received.
                    ReciveDone.Set();
                    //  Get the rest of the data.
                    client.BeginReceive(state.Buffer, 0, state.BufferSize, 0, new AsyncCallback(ReceiveCallback), state);
                }
                else
                {
                    // All the data has arrived; put it in response.
                    if (state.SB.Length > 1)
                    {
                        Monitor.Enter(ResultManager);
                        ResultManager.reciveXmlMessage(state.SB.ToString());
                        Trace.Write(state.SB.ToString());
                        Monitor.Exit(ResultManager);
                    }
                    // Signal that all bytes have been received.
                    ReciveDone.Set();
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.ToString());
            }
        }
        /// <summary>
        /// Event wird getriggerted wenn eine Nachricht empfangen wird.
        /// </summary>
        //public event EventHandler RecivedMessage;
        private static MessageManager ResultManager = new MessageManager();
        private static ManualResetEvent ConnectDone = new ManualResetEvent(false);
        private static ManualResetEvent SendDone = new ManualResetEvent(false);
        private static ManualResetEvent ReciveDone = new ManualResetEvent(false);
        protected static List<LoginData> Logins;
        private static List<Socket> Sockets;
    }
}
