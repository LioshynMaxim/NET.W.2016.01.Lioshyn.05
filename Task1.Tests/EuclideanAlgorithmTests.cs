﻿using NUnit.Framework;
using static Task1.GreatestCommonDivisor;

namespace Task1.Tests
{
    [TestFixture]
    public class EuclideanAlgorithmTests
    {
        [TestCase(24, 42, ExpectedResult = 6)]
        [TestCase(72, 64, ExpectedResult = 8)]
        [TestCase(64, 72, ExpectedResult = 8)]
        [TestCase(42, 24, ExpectedResult = 6)]
        public int EuclideanGreatestCommonDivisorTwoTest(int a, int b)
        {
            return EuclideanAlgorithm(a, b);
        }

        [TestCase(new[] {36, 60, 42}, ExpectedResult = 6)]
        [TestCase(new[] {168, 180, 3024}, ExpectedResult = 12)]
        [TestCase(new[] {2340, 1080, 100}, ExpectedResult = 20)]
        [TestCase(new[] {2340, 1080, 100, 70}, ExpectedResult = 10)]
        [TestCase(new[] {2340, 1080, 100, 70, 140, 250}, ExpectedResult = 10)]
        public int EuclideanGreatestCommonDivisorAnyTest(int[] arrInts)
        {
            return EuclideanAlgorithm(arrInts);
        }
    }

    [TestFixture]
    public class SteinAlgorithmTests
    {
        [TestCase(24, 42, ExpectedResult = 6)]
        [TestCase(72, 64, ExpectedResult = 8)]
        [TestCase(64, 72, ExpectedResult = 8)]
        [TestCase(42, 24, ExpectedResult = 6)]
        public int SteinGreatestCommonDivisorTwoTest(int a, int b)
        {
            return SteinAlgorithm(a, b);
        }

        [TestCase(new[] {36, 60, 42}, ExpectedResult = 6)]
        [TestCase(new[] {168, 180, 3024}, ExpectedResult = 12)]
        [TestCase(new[] {2340, 1080, 100}, ExpectedResult = 20)]
        [TestCase(new[] {2340, 1080, 100, 70}, ExpectedResult = 10)]
        [TestCase(new[] {2340, 1080, 100, 70, 140, 250}, ExpectedResult = 10)]
        public int SteinGreatestCommonDivisorAnyTest(int[] arrInts)
        {
            return SteinAlgorithm(arrInts);
        }
    }
}