using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Sockets;

namespace Model.Manager.States
{
    public class StateObject
    {
        public StateObject()
        {
            bufferSize = 256;
        }
        /// <summary>
        /// Property des Client Sockets
        /// </summary>
        public Socket WorkSocket
        {
            get
            {
                return workSocket;
            }
            set
            {
                workSocket = value;
            }
        }
        /// <summary>
        /// Größe des RecivingBuffers
        /// </summary>
        public int BufferSize
        {
            get
            {
                return bufferSize;
            }
        }
        /// <summary>
        /// RecingBuffer
        /// </summary>
        public byte[] Buffer
        {
            get
            {
                return buffer;
            }
            set
            {
                buffer = value;
            }
        }
        /// <summary>
        /// Recived data String
        /// </summary>
        public StringBuilder SB
        {
            get
            {
                return sb;
            }
            set
            {
                sb = value;
            }
        }
        // Client socket.
        private Socket workSocket = null;
        // Size of receive buffer.
        private static int bufferSize;
        // Receive buffer.
        private byte[] buffer = new byte[bufferSize];
        // Received data string.
        private StringBuilder sb = new StringBuilder();
    }
}
