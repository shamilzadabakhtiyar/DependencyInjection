using Microsoft.AspNetCore.Mvc;

namespace DependencyInjection.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly INumGenerator _numGenerator1;
        private readonly INumGenerator _numGenerator2;

        public WeatherForecastController(INumGenerator numGenerator1, INumGenerator numGenerator2)
        {
            _numGenerator1 = numGenerator1;
            _numGenerator2 = numGenerator2;
        }

        [HttpGet]
        public string Get()
        {
            return $"{_numGenerator1.RandomValue} - {_numGenerator2.RandomValue}";
        }
    }
}