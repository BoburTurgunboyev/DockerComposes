using Microsoft.AspNetCore.Mvc;
using ProjectThree1;
using ProjectThree2;
using ProjectThree3;

namespace ProjectThreee.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class WeatherForecastController : ControllerBase
    {
        public IActionResult GetName()
        {
            return Ok(Class1.name);
        }

        public IActionResult GetName2()
        {
            return Ok(Class2.name);

        }
        public IActionResult GetName3()
        {
            return Ok(Class3.name);
        }
    }
}