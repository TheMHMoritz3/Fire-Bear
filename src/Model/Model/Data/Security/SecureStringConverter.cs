using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Model.Data.Security
{
    public class SecureStringConverter
    {
        /// <summary>
        /// Use Only for Testing
        /// </summary>
        /// <param name="sValue"></param>
        /// <returns></returns>
        public static SecureString convertFromString(string sValue)
        {
            SecureString returnValue = new SecureString();
            foreach(char cValue in sValue.ToCharArray())
            {
                returnValue.AppendChar(cValue);
            }
            return returnValue;
        }
    }
}
