using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using NUnit.Framework;
using Model.Manager.States;

namespace TestModel.Manager.States
{
    [TestFixture]
    public class StateObjectTest
    {
        [Test]
        public void testBufferSizeProperty()
        {
            StateObject testobject = new StateObject();
            Assert.IsTrue(testobject.BufferSize==256);
        }

        [Test]
        public void testStringBuilderProperty()
        {
            StateObject testobject = new StateObject();
            Assert.IsTrue(testobject.SB!=null);
        }

        [Test]
        public void testWorkSocketProperty()
        {
            StateObject testobject = new StateObject();
            Assert.IsTrue(testobject.WorkSocket==null);
        }
    }
}
