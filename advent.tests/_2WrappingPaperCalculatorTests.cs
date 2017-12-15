using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advent;
using NUnit.Framework;
using NUnit.Framework.Internal.Builders;

namespace advent.tests
{
    [TestFixture]
    class _2WrappingPaperCalculatorTests
    {
        [TestCase(2, 3, 4, 58)]
        [TestCase(1, 1, 10, 43)]
        public void TestWrappingPaperCalculator(int d1, int d2, int d3, int expectedFeetOfPaper)
        {
            var sut = new _2WrappingPaperTestCalculator();
            Assert.AreEqual(expectedFeetOfPaper, sut.Calculate(d1, d2, d3));
        }

        [TestCase(2, 3, 4, 34)]
        [TestCase(1, 1, 10, 14)]
        public void TestRibbonCalculator(int d1, int d2, int d3, int expectedLengthOfRibbon)
        {
            var sut = new _2WrappingPaperTestCalculator();
            Assert.AreEqual(expectedLengthOfRibbon, sut.CalculateRibbon(d1, d2, d3));
        }
    }
}
