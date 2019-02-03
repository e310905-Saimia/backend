using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorExample.Models
{
    public class Calculator
    {
        public Calculator()
        {
            X = 0;
            Y = 0;
            CalOperation = CalculatorOperation.NotDone;
        }

        public Calculator(int? x, int? y)
        {
            X = x;
            Y = y;
            CalOperation = CalculatorOperation.NotDone;
        }

        public int? X { get; set; }
        public int? Y { get; set; }
        public CalculatorOperation CalOperation { get; set; }

        public bool CalculationSuccess { get; set; }        
        public string ErrorMessage { get; set; }     
        public int CalculationResult { get; set; }

        public enum CalculatorOperation
        {
            NotDone = 0,
            Sum = 1,            
            Multiplication = 2
        }
    }
}
