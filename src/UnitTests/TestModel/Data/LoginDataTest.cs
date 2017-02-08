using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

using Model.Data;
using Model.Data.Security;
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TestModel.Data
{
    [TestFixture]
    class LoginDataTest
    {
        [Test]
        public void TestLoginConstructor()
        {

            LoginData testobject = new LoginData(SecureStringConverter.convertFromString("test"), SecureStringConverter.convertFromString("test"), "test.de");
            Assert.That(testobject.getDomain(), Is.EqualTo("test.de"));
            Assert.That(Marshal.PtrToStringUni(Marshal.SecureStringToCoTaskMemUnicode(testobject.getPassword())), Is.EqualTo("test"));
            Assert.That(Marshal.PtrToStringUni(Marshal.SecureStringToCoTaskMemUnicode(testobject.getUsername())), Is.EqualTo("test"));
        }

        [Test]
        public void TestDomainGetter()
        {
            LoginData testobject = new LoginData(SecureStringConverter.convertFromString("test"), SecureStringConverter.convertFromString("test"), "test.de");
            Assert.That(testobject.getDomain(), Is.EqualTo("test.de"));
        }

        [Test]
        public void TestPasswordGetter()
        {
            LoginData testobject = new LoginData(SecureStringConverter.convertFromString("test"), SecureStringConverter.convertFromString("test"), "test.de");
            Assert.That(Marshal.PtrToStringUni(Marshal.SecureStringToCoTaskMemUnicode(testobject.getPassword())), Is.EqualTo("test"));
        }

        [Test]
        public void TestUsernameGetter()
        {
            LoginData testobject = new LoginData(SecureStringConverter.convertFromString("test"), SecureStringConverter.convertFromString("test"), "test.de");
            Assert.That(Marshal.PtrToStringUni(Marshal.SecureStringToCoTaskMemUnicode(testobject.getUsername())), Is.EqualTo("test"));
        }
    }
}
