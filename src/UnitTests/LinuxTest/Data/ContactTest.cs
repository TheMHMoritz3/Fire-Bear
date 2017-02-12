using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.Data;
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TestModel.Data
{
    [TestFixture]
    class ContactTest
    {
        [Test]
        public void testConstructor()
        {
            Contact contact = new Contact("fIREbEAR","german-software-engineers.com");
            Assert.That(contact.UserName, Is.EqualTo("fIREbEAR"));
            Assert.That(contact.Server, Is.EqualTo("german-software-engineers.com"));
        }

        [Test]
        public void testPropertieUserName()
        {
            Contact contact = new Contact();
            contact.UserName = "fIREbEAR";
            Assert.That(contact.UserName, Is.EqualTo("fIREbEAR"));
        }

        [Test]
        public void testPropertieServer()
        {
            Contact contact = new Contact();
            contact.Server = "german-software-engineers.com";
            Assert.That(contact.Server, Is.EqualTo("german-software-engineers.com"));
        }
    }
}
