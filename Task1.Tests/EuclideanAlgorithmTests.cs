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
        public int GreatestCommonSivisorTest(int a, int b)
        {
            return GreatestCommonSivisor(a, b);
        }

        
    }
}