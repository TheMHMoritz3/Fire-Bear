using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model.Data.XML;
using NUnit.Framework;

namespace TestModel.Data.XML
{
    [TestFixture]
    public class XMLElementTest
    {
        [Test]
        public void testSimpleConstructor()
        {
            XMLElement element = new XMLElement();
            Assert.That(element.XMLTag, Is.EqualTo(""));
        }

        [Test]
        public void testXMLTag()
        {
            XMLElement element = new XMLElement();
            element.XMLTag = "Test";
            Assert.That(element.XMLTag, Is.EqualTo("Test"));
        }

        [Test]
        public void testSimpleXMLElements()
        {
            XMLElement element = new XMLElement();
            element.Add("TestOne", "Test");
            Assert.That(element.Get("TestOne"), Is.EqualTo("Test"));
        }

        [Test]
        public void testExtentedXMLElements()
        {
            XMLElement element = new XMLElement();
            element.Add("TestOne", "Test");
            Assert.That(element.Get("TestOne"), Is.EqualTo("Test"));
            element.Add("TestTwo", "TestOne");
            Assert.That(element.Get("TestOne"), Is.EqualTo("Test"));
            Assert.That(element.Get("TestTwo"), Is.EqualTo("TestOne"));
        }
    }
}
