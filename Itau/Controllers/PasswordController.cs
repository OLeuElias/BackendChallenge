using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using Itau.Validators;
using Itau.ViewModel;
namespace Itau.Controllers
{
    [ApiController]
    [Route("api/{controller}")]
    [Produces("application/json")]

    public class PasswordController : ControllerBase
    {
        [HttpPost("Validate")]
        public IActionResult Validate(PasswordJson p)
        {
            IPassword validator = new PasswordValidator(p.password);
            if(p.password == null)
            {
                //return false;
                return Ok(false);
            }
            validator.sizeValidation();
            validator.hasUppercase();
            validator.hasLowercase();
            validator.hasNumber();
            validator.hasSpecialCharacter();
            validator.hasRepeatedCharacter();

            //return validator.validate();
            return Ok(validator.validate());
        }
    }
}
