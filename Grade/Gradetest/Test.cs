using NUnit.Framework;
using System;
namespace Gradetest
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {

            Assert.AreEqual(3, 4);
        }
    }
}
