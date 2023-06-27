using Microsoft.AspNetCore.Mvc;

namespace TaxiFinder.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FinderController : ControllerBase
    {
        private readonly TaxiFinderService _taxiFinderService;

        public Finder(TaxiFinderService taxiFinderService)
        {
            this._taxiFinderService = taxiFinderService;
        }

        [HttpGet]
        public IEnumerable<WeatherForecast> Get()
        {
           this._taxiFinderService.GetAll();
        }
    }
}