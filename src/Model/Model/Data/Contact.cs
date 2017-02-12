using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class Contact
    {
        /// <summary>
        /// used to Safe Contact Information for messaging
        /// </summary>
        public Contact()
        {
            _UserName = "";
            _Server = "";
        }

        public Contact(string userName, string server)
        {
            _UserName = userName;
            _Server = server;
        }

        /// <summary>
        /// returns or sets the Name of the contact, which is dicplaeyd and used on its Server
        /// </summary>
        public string UserName
        {
            set
            {
                _UserName = value;
            }

            get
            {
                return _UserName;
            }
        }

        /// <summary>
        /// returns or sets the Adress of the Server, which the Contact uses
        /// </summary>
        public string Server
        {
            set
            {
                _Server = value;
            }

            get
            {
                return _Server;
            }
        }

        private string _UserName;
        private string _Server;
    }
}
