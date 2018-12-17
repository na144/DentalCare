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
            string expected = testView.getClientPersNum(validPNum);

            //assert
            Assert.AreEqual(validPNum, expected);
        }

         [TestMethod]
        public void invalid_PersNum()
        {
            //act
            string expected = testView.getClientPersNum(invalidPNum);

            //assert
            Assert.AreNotEqual(invalidPNum, expected);
        }

    }
}
