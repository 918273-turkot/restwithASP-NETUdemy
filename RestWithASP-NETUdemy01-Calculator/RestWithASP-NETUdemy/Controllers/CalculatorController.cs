using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RestWithASP_NETUdemy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {

        // GET api/values/Sum/5/5
        [HttpGet("sum/{firstNumber}/{secondNamber}")]
        public IActionResult Sum(string firstNumber, string secondNamber)
        {
            
           if(IsNumeric(firstNumber) && IsNumeric(secondNamber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNamber);   
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }
        // GET api/values/Subtraction/5/5
        [HttpGet("subtraction/{firstNumber}/{secondNamber}")]
        public IActionResult Subtraction(string firstNumber, string secondNamber)
        {

            if (IsNumeric(firstNumber) && IsNumeric(secondNamber))
            {
                var sum = ConvertToDecimal(firstNumber) - ConvertToDecimal(secondNamber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }
        // GET api/values/multiplication/5/5
        [HttpGet("multiplication/{firstNumber}/{secondNamber}")]
        public IActionResult Multiplication(string firstNumber, string secondNamber)
        {

            if (IsNumeric(firstNumber) && IsNumeric(secondNamber))
            {
                var sum = ConvertToDecimal(firstNumber) * ConvertToDecimal(secondNamber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }
        // GET api/values/division/5/5
        [HttpGet("division/{firstNumber}/{secondNamber}")]
        public IActionResult Division(string firstNumber, string secondNamber)
        {

            if (IsNumeric(firstNumber) && IsNumeric(secondNamber))
            {
                var sum = ConvertToDecimal(firstNumber) / ConvertToDecimal(secondNamber);
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }
        // GET api/values/division/5/5
        [HttpGet("mean/{firstNumber}/{secondNamber}")]
        public IActionResult Mean(string firstNumber, string secondNamber)
        {

            if (IsNumeric(firstNumber) && IsNumeric(secondNamber))
            {
                var sum = (ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNamber))/2;
                return Ok(sum.ToString());
            }
            return BadRequest("Invalid Input");
        }
        // GET api/values/square-root/5
        [HttpGet("square-root/{number}")]
        public IActionResult SquareRoot(string number)
        {

            if (IsNumeric(number))
            {
                var sumsquareRoot = Math.Sqrt((double)ConvertToDecimal(number));
                return Ok(sumsquareRoot.ToString());
            }
            return BadRequest("Invalid Input");
        }

        private decimal ConvertToDecimal(string number)
        {
            decimal decimalValue = 0;
            if (decimal.TryParse(number, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }
        
        private bool IsNumeric(string strNumber)
        {
                double number=0;
                bool isNumber = double.TryParse(strNumber,
                                                System.Globalization.NumberStyles.Any,
                                                System.Globalization.NumberFormatInfo.InvariantInfo,
                                                out number);
                return true;

        }        
    }
}
