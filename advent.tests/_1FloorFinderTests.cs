using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advent;
using NUnit.Framework;

namespace advent.tests
{
    [TestFixture]
    public class _1FloorFinderTests
    {
        [TestCase("(())", 0)]
        [TestCase("))(((((", 3)]
        public void TestFloorFinder(string input, int expectedFloor)
        {
            var sut = new _1FloorFinder();
            Assert.AreEqual(expectedFloor, sut.FindFloor(input));
        }

        [TestCase(")", 1)]
        [TestCase("()())", 5)]
        public void TestBasementCharacterFinder(string input, int expectedCharacterPosition)
        {
            var sut = new _1FloorFinder();
            Assert.AreEqual(expectedCharacterPosition, sut.FindBasementEnteringCharacterPosition(input));
        }
    }
}
