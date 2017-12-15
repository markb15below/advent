using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Advent;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace advent.tests
{
    [TestFixture]
    class _3PresentDeliveryTrackerTests
    {
        [TestCase(">", 2)]
        [TestCase("^>v<", 4)]
        [TestCase("^v^v^v^v^v", 2)]
        public void TestPresentDeliveryTracker(string input, int expectedHousesWithPresent)
        {
            var sut = new _3PresentDeliveryTracker();
            Assert.AreEqual(expectedHousesWithPresent, sut.Track(input));
        }

        [TestCase("^v", 3)]
        [TestCase("^>v<", 3)]
        [TestCase("^v^v^v^v^v", 11)]
        public void TestRoboPresentDeliveryTracker(string input, int expectedHousesWithPresent)
        {
            var sut = new _3PresentDeliveryTracker();
            Assert.AreEqual(expectedHousesWithPresent, sut.TrackRobot(input));
        }
    }
}
