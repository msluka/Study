using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculatorTest
{
    [TestClass]

    
    public class CalculatorTests
    {
        private Calculator.Calculator _calculator;

        [TestInitialize]
        public void Initialize()
        {
            _calculator = new Calculator.Calculator();
        }

        [TestMethod]

        public void Add_PassTwoSmallIntegers_ReturnsAdditionResult()
        {
            //Arrange
            var a = 10;
            var b = 4;
            var expectedResult = 14;

            //Act
            var result = _calculator.Add(a, b);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        public void Add_PassTwoMaxlIntegers_ThrowsOverflowException()
        {

            //Arrange
            var a = int.MaxValue;
            var b = int.MinValue;

            //Act
            var result = _calculator.Add(a, b);

            //Assert
        }

        [TestMethod]

        public void Devide_PassTwoIntegersWhichAreDevide_ReturnsCorrectResult()
        {
            //Arrange
            var a = 10;
            var b = 5;
            var expectedResult = 2d;

            //Act
            var result = _calculator.Divide(a, b);

            //Assert
            Assert.AreEqual(expectedResult, result);
        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void Devide_PassTwoIntegersWhichAreNotDevided_ThrowsOverflowException()
        {
            //Arrange
            var a = 12;
            var b = 0;
           
            //Act
            var result = _calculator.Divide(a, b);

            //Assert
        }
    }
}
