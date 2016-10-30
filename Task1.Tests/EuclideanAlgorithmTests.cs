using NUnit.Framework;
using static Task1.EuclideanAlgorithm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1.Tests
{
    [TestFixture()]
    public class EuclideanAlgorithmTests
    {
        [TestCase(24, 42, ExpectedResult = 6)]
        [TestCase(72, 64, ExpectedResult = 8)]
        [TestCase(64, 72, ExpectedResult = 8)]
        [TestCase(42, 24, ExpectedResult = 6)]
        public int GreatestCommonSivisorTwoTest(int a, int b)
        {
            return GreatestCommonSivisor(a, b);
        }

        [TestCase(new int[] { 36, 60, 42 }, ExpectedResult = 6)]
        [TestCase(new int[] { 168, 180, 3024 }, ExpectedResult = 12)]
        [TestCase(new int[] { 2340, 1080, 100 }, ExpectedResult = 20)]
        [TestCase(new int[] { 2340, 1080, 100, 70 }, ExpectedResult = 10)]
        [TestCase(new int[] { 2340, 1080, 100, 70, 140, 250 }, ExpectedResult = 10)]
        public int GreatestCommonSivisorThreeTest(int[] arrInts)
        {
            return GreatestCommonSivisor(arrInts);
        }



    }
}