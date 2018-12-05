using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DentalCare;

namespace DentalCareTests
{
    [TestClass]
    public class EncryptionTest
    {
        [TestMethod]
        public void HasherTestWithSalt()
        {
            const string original = "timetravel";

            var h = new Hasher();
            var s = h.Encrypt(original);
            var s2 = h.Encrypt(original);

            Assert.AreNotEqual(original, s);
            Assert.AreNotEqual(original, s2);
            Assert.AreNotEqual(s, s2);

            Assert.IsTrue(h.CompareStringToHash(original, s));
            Assert.IsTrue(h.CompareStringToHash(original, s2));
        }

        [TestMethod]
        public void HasherTestWithoutSalt()
        {
            const string original = "spaceodyssey";

            var h = new Hasher {SaltSize=0 };
            var s = h.Encrypt(original);
            var s2 = h.Encrypt(original);

            Assert.AreNotEqual(original, s);
            Assert.AreNotEqual(original, s2);
            Assert.AreEqual(s, s2);

            Assert.IsTrue(h.CompareStringToHash(original, s));
            Assert.IsTrue(h.CompareStringToHash(original, s2));
        }
    }
}
