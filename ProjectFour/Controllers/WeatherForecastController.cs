using Microsoft.AspNetCore.Mvc;
using ProjectFour1;
using ProjectFour2;
using ProjectFour3;

namespace ProjectFour.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        [HttpGet]

        public IActionResult GetName()
        {
            return Ok(Class1.name);
        }

        [HttpGet]
        public IActionResult GetName2()
        {
            return Ok(Class2.name);
        }

        [HttpGet]

        public IActionResult GetName3()
        {
            return Ok(Class3.name);
        }





    }
}