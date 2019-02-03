using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorExample.Models;

namespace CalculatorExample.Services
{
    public interface ICalculatorX
    {
        Calculator Sum(int x, int y);
        Calculator SumObj(Calculator calculator);
        Calculator Multiplication(Calculator calculator);        
    }
}
