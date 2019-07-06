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
        
        // GET api/values/5/5
        [HttpGet("{firstNumber}/{secondNamber}")]
        public IActionResult Sum(string firstNumber, string secondNamber)
        {
            
           if(IsNumeric(firstNumber) && IsNumeric(secondNamber))
            {
                var sum = ConvertToDecimal(firstNumber) + ConvertToDecimal(secondNamber);   
                return Ok(sum.ToString());
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
