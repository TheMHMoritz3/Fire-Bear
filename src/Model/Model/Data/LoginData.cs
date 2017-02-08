using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data
{
    public class LoginData
    {
        public LoginData(SecureString username, SecureString password, string domain)
        {
            _Username = username;
            _Password = password;
            _Domain = domain;
        }

        public SecureString getUsername()
        {
            return _Username;
        }

        public SecureString getPassword()
        {
            return _Password;
        }

        public string getDomain()
        {
            return _Domain;
        }

        public static bool operator == (LoginData valueOne, LoginData otherValue)
        {
            return ((valueOne._Username == otherValue._Username)&&(valueOne._Domain == otherValue._Domain));
        }

        public static bool operator != (LoginData valueOne, LoginData otherValue)
        {
            return ((valueOne._Username != otherValue._Username)||(valueOne._Domain!=otherValue._Domain));
        }

        private SecureString _Username;
        private SecureString _Password;
        private string _Domain;
    }
}
