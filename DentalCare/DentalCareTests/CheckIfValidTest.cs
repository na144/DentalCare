using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DentalCare;

namespace DentalCareTests
{
    [TestClass]
    public class CheckIfValidTest
    {
        [TestMethod]
        public void TestCheckFormatRealPersonalNumber()
        {
            var validator = new CheckIfValid();
            string pNumberReal = "19800412-4444";

            Assert.IsTrue(validator.checkPersonalNumber(pNumberReal));
        }

        [TestMethod]
        public void TestCheckFormatFalsePersonalNumber()
        {
            var validator = new CheckIfValid();
            string pNumberFalse = "19980801";

            Assert.IsFalse(validator.checkPersonalNumber(pNumberFalse));
        }
    }
}
