using NUnit.Framework;
using static Task2.BubbleSort;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Tests
{
    [TestFixture()]
    public class BubbleSortTests
    {
        public int[][] ArrForFirstTest = new[]
            {
                new []{6, -5, 3, 0, 10},
                new []{1, 2, 1, 0, 1},
                new []{0, 2, 0, 0, 30, 0},
                new []{0, 2, 0, 29, -1}
            };

        public int[][] ArrNewInts = new[]
            {
                new []{0, 2, 0, 0, 30, 0},
                new []{0, 2, 0, 29, -1},
                new []{6, -5, 3, 0, 10},
                new []{1, 2, 1, 0, 1}
            };

        [Test()]
        public void BubbleSortSumElementsTest()
        {
            BubbleSortSumElements(ref ArrForFirstTest, new BubbleSort(), true);
            Assert.AreEqual(ArrForFirstTest, ArrNewInts);
        }

        [Test()]
        public void BubbleSortMaxElementsTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void BubbleSortMinElementsTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void MinValTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void SortSumTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void SortMaxTest()
        {
            Assert.Fail();
        }

        [Test()]
        public void SortMinTest()
        {
            Assert.Fail();
        }
    }
}