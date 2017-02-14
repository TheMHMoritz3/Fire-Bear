using System.Security;

namespace Model.Data
{
    public class LoginData
    {
        public LoginData(string username, SecureString password, string domain)
        {
            _Username = username;
            _Password = password;
            _Domain = domain;
        }

        public string getUsername()
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
            return ((valueOne._Username.Equals(otherValue._Username))&&(valueOne._Domain.Equals(otherValue._Domain)));
        }

        public static bool operator != (LoginData valueOne, LoginData otherValue)
        {
            return (!(valueOne._Username.Equals(otherValue._Username)) || !(valueOne._Domain.Equals(otherValue._Domain)));
        }

        public override bool Equals(System.Object obj)
        {
            if (obj == null)
                return false;

            LoginData testObject;

            try
            {
                testObject = (LoginData)obj;
            }
            catch
            {
                return false;
            }

            return (testObject == this);
        }

        public override int GetHashCode()
        {
            return _Username.GetHashCode() + _Password.GetHashCode() + _Domain.GetHashCode();
        }

        private string _Username;
        private SecureString _Password;
        private string _Domain;
    }
}
