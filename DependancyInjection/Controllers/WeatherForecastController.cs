using Microsoft.AspNetCore.Mvc;

namespace DependancyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly INumberGenerator numGenerator;

        public WeatherForecastController(INumberGenerator numberGenerator) 
        {
            numGenerator = numberGenerator;
        }  

        [HttpGet]
        public string Get()
        {
            return numGenerator.RandomValue.ToString();
        }

    }
}