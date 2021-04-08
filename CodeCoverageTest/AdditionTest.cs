using CodeCoverage.Classes;
using CodeCoverage.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace CodeCoverageTest
{
    [TestClass]
    public class AdditionTest
    {
        [TestMethod]
        public void Given_I_Have_Two_Numbers_When_I_Call_AddTwoIntegers_Method_Then_I_Verify_Integer_Result_Is_Returned()
        {
            //Given: I have 2 integers
            int numberOne = 10;
            int numberTwo = 30;
            int expectedResult = 40;

            //WHen: I call AddTwoIntegers method
            IAddition addition = new Addition();
            int actualResult = addition.AddTwoIntegers(numberOne, numberTwo);

            //Then: I verify Int32 is returned as result
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void Given_I_Have_Two_Numbers_One_Is_Int32_Max_When_I_Call_AddTwoIntegers_Method_Then_I_Verify_Exception_Is_Thrown()
        {
            //Given: I have 2 integers
            int numberOne = Int32.MaxValue;
            int numberTwo = 30;

            //WHen: I call AddTwoIntegers method
            IAddition addition = new Addition();
            int actualResult = addition.AddTwoIntegers(numberOne, numberTwo);

            //Then: I verify Exception is thrown
        }
    }
}
