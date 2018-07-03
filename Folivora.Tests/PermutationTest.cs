using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Folivora.Tests
{
    [TestClass]
    public class PermutationTest
    {
        [TestMethod]
        public void TestConst()
        {
            AssertPrediction(1, 1, 1, 1, 1, 1);
            AssertPrediction(0, 0, 0, 0, 0);
            AssertPrediction(42, 42, 42, 42, 42, 42);
        }

        [TestMethod]
        public void TestLinear()
        {
            AssertPrediction(6, 1, 2, 3, 4, 5);
            AssertPrediction(11, 3, 5, 7, 9);
            AssertPrediction(1, -1, 1, -1, 1, -1);
            AssertPrediction(-12, 2, -4, 6, -8, 10);
        }

        [TestMethod]
        public void TestAlgebraic()
        {
            AssertPrediction(64, 1, 4, 9, 16, 25, 36, 49);
            AssertPrediction(64, 4, 9, 16, 25, 36, 49);
            AssertPrediction(65, 2, 5, 10, 17, 26, 37, 50);
            AssertPrediction(216, 1, 8, 27, 64, 125);
        }

        [TestMethod]
        public void TestRecursive()
        {
            AssertPrediction(34, 1, 1, 2, 3, 5, 8, 13, 21);
        }

        [TestMethod]
        public void TestGroup()
        {
            AssertPrediction(4, 1, 1, 2, 1, 2, 3, 1, 2, 3);
            AssertPrediction(3, 1, 1, 2, 1, 2, 3, 1, 2, 3, 4, 1, 2);
            AssertPrediction(5, 1, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 4, 4, 4, 4, 5);
            AssertPrediction(5, 1, 2, 1, 3, 2, 1, 4, 3, 2, 1);
        }

        [TestMethod]
        public void TestMixed()
        {
            AssertPrediction(1, 1, 3, 1, 3, 1, 3);
            AssertPrediction(14, 1, 10, 2, 11, 3, 12, 4, 13, 5);
        }

        void AssertPrediction(int expected, params int[] array)
        {
            Assert.AreEqual(expected, Permutation.PredictNext(array));
        }
    }
}
