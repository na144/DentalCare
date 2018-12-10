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
        string pNumberPattern = "^\\d{8}-\\{4}$";


        [TestMethod]
        public void valid_PersNum()
        {
            //act
            string expected = testView.getClientPersNum(validPNum, pNumberPattern);

            //asser
            Assert.AreEqual(validPNum, expected);
        }
/*
        [TestMethod]
        //fel
        public void checkApplPersInTxb()
        {

            string clientPers = testView.getClientPersNum();


            
            if (System.Text.RegularExpressions.Regex.IsMatch(clientPers, pNumberPattern))
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid - only digits available");
            }

            
        }
        */
    }
}
