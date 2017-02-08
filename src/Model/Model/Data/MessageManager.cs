using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Model.Data
{
    /// <summary>
    /// TODO: Klasse Rausschmeißen
    /// </summary>
    class MessageManager
    {
        /// <summary>
        /// MessageManager
        /// </summary>
        public MessageManager()
        {
            Logins = new List<LoginData>();
            //Partner = new List<Contact>();
        }
        /// <summary>
        /// Nachricht wird empfangen und verarbeitet.
        /// </summary>
        /// <param name="xmlMessage">Nachricht im XML-Format</param>
        public void reciveXmlMessage(string xmlMessage)
        {
            Monitor.Enter(this);
            XML.XMLElement element = XML.XMLParser.getXMlElementOfString(xmlMessage);
            Monitor.Exit(this);
        }

        private List<LoginData> Logins;
        //private List<Contact> Partner;

    }
}
