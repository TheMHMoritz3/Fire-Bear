using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using System.Security;

using Model.Data.Security;
using System.Runtime.InteropServices;

namespace TestModel.Data.Security
{
    [TestFixture]
    public class TestSecureStringConverter
    {
        [Test]
        public void ConvertToSecureStringBasicTest()
        {
            SecureString securedString = SecureStringConverter.convertFromString("test");
            Assert.AreEqual("test", Marshal.PtrToStringUni(Marshal.SecureStringToCoTaskMemUnicode(securedString)));
        }

        [Test]
        public void ConvertToSecureStringEmptyStringTest()
        {
            SecureString securedString = SecureStringConverter.convertFromString("");
            Assert.AreEqual("", Marshal.PtrToStringUni(Marshal.SecureStringToCoTaskMemUnicode(securedString)));
        }
    }
}
