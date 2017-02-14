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
        public void testLoginConstructor()
        {

            LoginData testobject = new LoginData("test",
                SecureStringConverter.convertFromString("test"), "test.de");
            Assert.That(testobject.getDomain(), Is.EqualTo("test.de"));
            Assert.That(Marshal.PtrToStringUni(Marshal.SecureStringToCoTaskMemUnicode(testobject.getPassword())),
                Is.EqualTo("test"));
            Assert.That(testobject.getUsername(),
                Is.EqualTo("test"));
        }

        [Test]
        public void testDomainGetter()
        {
            LoginData testobject = new LoginData("test",
                SecureStringConverter.convertFromString("test"), "test.de");
            Assert.That(testobject.getDomain(), Is.EqualTo("test.de"));
        }

        [Test]
        public void testPasswordGetter()
        {
            LoginData testobject = new LoginData("test",
                SecureStringConverter.convertFromString("test"), "test.de");
            Assert.That(Marshal.PtrToStringUni(Marshal.SecureStringToCoTaskMemUnicode(testobject.getPassword())),
                Is.EqualTo("test"));
        }

        [Test]
        public void testUsernameGetter()
        {
            LoginData testobject = new LoginData("test",
                SecureStringConverter.convertFromString("test"), "test.de");
            Assert.That(testobject.getUsername(),
                Is.EqualTo("test"));
        }

        [Test]
        public void testEqualOperator()
        {
            LoginData testObjectOne=new LoginData("test", SecureStringConverter.convertFromString("test"), "test.de");
            LoginData testObjectTwo = new LoginData("test", SecureStringConverter.convertFromString("test"), "test.de");
            Assert.True(testObjectOne==testObjectTwo);
        }

        [Test]
        public void testNotEqualOperator()
        {
            LoginData testObjectOne = new LoginData("test", SecureStringConverter.convertFromString("test"), "test.de");
            LoginData testObjectTwo = new LoginData("test", SecureStringConverter.convertFromString("test"), "test.de");
            Assert.False(testObjectOne != testObjectTwo);
        }

        [Test]
        public void testEquals()
        {
            LoginData testObjectOne = new LoginData("test", SecureStringConverter.convertFromString("test"), "test.de");
            LoginData testObjectTwo = new LoginData("test", SecureStringConverter.convertFromString("test"), "test.de");
            Assert.True(testObjectOne.Equals(testObjectTwo));
        }
    }
}
