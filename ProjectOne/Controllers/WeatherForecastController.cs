using Microsoft.AspNetCore.Mvc;
using ProjectOne1;
using ProjectOne2;
using ProjectOne3;

namespace ProjectOne.Controllers
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