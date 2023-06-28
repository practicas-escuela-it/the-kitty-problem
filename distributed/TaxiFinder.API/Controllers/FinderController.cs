using Microsoft.AspNetCore.Mvc;
using TaxiFinder.API.Domain;

namespace TaxiFinder.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FinderController : ControllerBase
    {
        private readonly TaxiFinderService _taxiFinderService;

        public FinderController(TaxiFinderService taxiFinderService)
        {
            this._taxiFinderService = taxiFinderService;
        }

        [HttpGet]
        public IEnumerable<TaxiFound> Get()
        {
            return this._taxiFinderService.Invoke();
        }
    }
}