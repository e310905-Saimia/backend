using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorExample.Models;

namespace CalculatorExample.Services
{
    public class CalculatorX:ICalculatorX
    {
        public Calculator Sum(int x, int y)
        {
            Calculator calculator = new Calculator(x,y);
            calculator.CalOperation = Calculator.CalculatorOperation.Sum;
            calculator.ErrorMessage = null;
            calculator.CalculationResult = 0;

            if (!calculator.X.HasValue || !calculator.Y.HasValue)
            {
                calculator.ErrorMessage = "X tai Y arvo puuttuvat (null)";
                calculator.CalculationSuccess = false;
                return calculator;
            }

            checked
            {
                try
                {
                    calculator.CalculationResult = Convert.ToInt32(calculator.X + calculator.Y);
                    calculator.CalculationSuccess = true;
                }
                catch (Exception e)
                {
                    calculator.ErrorMessage = e.Message;
                    calculator.CalculationSuccess = false;
                }
            }
            return calculator;
        }
        

        public Calculator Sum(Calculator calculator)
        {
            calculator.CalOperation = Calculator.CalculatorOperation.Sum;
            calculator.ErrorMessage = null;
            calculator.CalculationResult = 0;

            if (!calculator.X.HasValue || !calculator.Y.HasValue)
            {
                calculator.ErrorMessage = "X tai Y arvo puuttuvat (null)";
                calculator.CalculationSuccess = false;
                return calculator;
            }

            checked
            {
                try
                {
                    calculator.CalculationResult = Convert.ToInt32(calculator.X + calculator.Y);
                    calculator.CalculationSuccess = true;
                }
                catch (Exception e)
                {
                    calculator.ErrorMessage = e.Message;
                    calculator.CalculationSuccess = false;
                }
            }

            return calculator;
        }

        public Calculator Multiplication(Calculator calculator)
        {
            throw new NotImplementedException();
        }
    }
}
