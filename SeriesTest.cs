using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OnlineTest.Business;

namespace OnlineTest.Test
{
    [TestFixture]
    public class SeriesTest
    {
        List<int> series = new List<int>();
        [SetUp]
        public void SetUp()
        {
           // series = SeriesManager.GenerateSeries(15);

        }
        

        [Test]
        public void TestCase1()
        {
            int result = SeriesManager.Search(3, 1);
            Assert.AreEqual(3, result);
        }

        [Test]
        public void TestCase2()
        {
            int result = SeriesManager.Search(3, 2);
            Assert.AreEqual(9, result);
        }

        [Test]
        public void TestCase3()
        {
            int result = SeriesManager.Search(3, 3);
            Assert.AreEqual(57, result);
        }

        [Test]
        public void TestCase4()
        {
            int result = SeriesManager.Search(5, 1);
            Assert.AreEqual(5, result);
        }

        [Test]
        public void TestCase5()
        {
            int result = SeriesManager.Search(5, 2);
            Assert.AreEqual(105, result);
        }

        [Test]
        public void TestCase6()
        {
            int result = SeriesManager.Search(5, 3);
            Assert.AreEqual(355, result);
        }

    }
}
