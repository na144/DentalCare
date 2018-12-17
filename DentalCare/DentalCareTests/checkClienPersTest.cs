using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DentalCare;

namespace DentalCareTests
{
    [TestClass]
    public class checkClientIPersNumTest
    {

        //arrange
        ClientInfoView testView = new ClientInfoView();
        string validPNum = "12345678-1234";
        string invalidPNum = "123456781234";
       


        [TestMethod]
        public void valid_PersNum()
        {
            //act
            bool valid = testView.isPersNumValid(validPNum);

            //assert
            Assert.IsTrue(valid);
        }

         [TestMethod]
        public void invalid_PersNum()
        {
            //act
            bool notValid = testView.isPersNumValid(invalidPNum);

            //assert
            Assert.IsFalse(notValid);
        //    Assert.AreNotEqual(invalidPNum, unexpected);
        }

    }
}
