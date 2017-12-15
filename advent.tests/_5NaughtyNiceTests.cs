using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advent;
using NUnit.Framework.Internal;
using NUnit.Framework;

namespace advent.tests
{
    [TestFixture]
    class _5NaughtyNiceTests
    {
        [TestCase("ugknbfddgicrmopn", true)]
        [TestCase("aaa", true)]
        [TestCase("jchzalrnumimnmhp", false)]
        [TestCase("haegwjzuvuyypxyu", false)]
        [TestCase("dvszwmarrgswjxmb", false)]
        public void TestNaughtyNice(string input, bool expectedNice)
        {
            var sut = new _5NaughtyNice();
            Assert.AreEqual(expectedNice, sut.IsNice(input));
        }
    }
}
