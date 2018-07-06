using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Folivora.Tests
{
    [TestClass]
    public class CaseTest
    {
        [TestMethod]
        public void TestConst()
        {
            AssertPrediction("10", "10",
                C("1", "1"),
                C("2", "2"),
                C("4", "4"),
                C("16", "16")
            );
        }

        void AssertPrediction(string input, string output, params Case[] cases)
        {
            Assert.AreEqual(output, CasePredict.Predict(cases, input));
        }

        Case C(string input, string output)
            => new Case(input, output);
    }
}
