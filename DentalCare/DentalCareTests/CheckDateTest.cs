using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DentalCare;

namespace DentalCareTests
{
    [TestClass]
    public class CheckDateTest
    {
        [TestMethod]
        public void TestDateReal()
        {
            var v = new CheckDate();
            string dateTrue = "2018-10-10";

            Assert.IsTrue(v.checkDateFormat(dateTrue));
        }

        [TestMethod]
        public void TestDateFalse()
        {
            var v = new CheckDate();
            string dateFalse = "20181010";

            Assert.IsFalse(v.checkDateFormat(dateFalse));
        }
    }
}