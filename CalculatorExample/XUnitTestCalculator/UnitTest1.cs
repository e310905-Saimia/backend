using System;
using CalculatorExample.Models;
using CalculatorExample.Services;
using Xunit;

namespace XUnitTestCalculator
{
    public class UnitTest1
    {
        [Fact]
        public void Sum_XandY_isNotNull_OutputOK()
        {
            CalculatorX calculatorX = new CalculatorX();
            Calculator calculator = new Calculator(3,4);            
            calculatorX.Sum(3, 4);
            Assert.Equal<int>(7,calculator.CalculationResult);
            Assert.False(calculator.CalculationSuccess);
            //Assert.Equal<Calculator.CalculatorOperation>(calculator.CalOperation, 1);
            Assert.Null(calculator.ErrorMessage);
        }
    }
}
