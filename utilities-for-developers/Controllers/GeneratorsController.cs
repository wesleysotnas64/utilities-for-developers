using Microsoft.AspNetCore.Mvc;

using utilities_for_developers.Services;

namespace utilities_for_developers.Controllers
{
    [ApiController]
    [Route("generator-api/")]
    public class GeneratorsController : ControllerBase
    {
        public GeneratorsController() { }

        [HttpGet("password")]
        public IActionResult GeneratePassword()
        {
            string password = new Generators().GeneratePassword();
            return Ok(password);
        }

        [HttpGet("cpf")]
        public IActionResult GenerateCPF()
        {
            string cpf = new Generators().GenerateCPF();
            return Ok(cpf);
        }
    }
}
