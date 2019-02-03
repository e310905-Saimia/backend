using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorExample.Models;
using CalculatorExample.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorsController : ControllerBase
    {
        private readonly ICalculatorX _calculator;

        public CalculatorsController(ICalculatorX calculator)
        {
            _calculator = calculator;
        }

        // GET api/calculators
        [HttpGet]
        //public ActionResult Sum(int x, int y)
        //{
        //    return new JsonResult(_calculator.Sum(x,y));
        //}
        public ActionResult Sum(Calculator calculator)
        {
            return new JsonResult(_calculator.Sum(calculator));
        }
    }
}