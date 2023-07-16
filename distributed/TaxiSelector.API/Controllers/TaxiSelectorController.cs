using Microsoft.AspNetCore.Mvc;
using TaxiSelector.API.Domain;
using TaxiSelector.API.Models;

namespace TaxiSelector.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaxiSelectorController : ControllerBase
    {
        private readonly Domain.TaxiSelector _taxiSelector;

        internal TaxiSelectorController(Domain.TaxiSelector taxiSelector)
        {
            this._taxiSelector = taxiSelector;
        }

        [HttpGet]
        public TaxiFound GetPropsedCandidateTaxis(TaxiSelectorRequest request)
        {
            return this._taxiSelector.Select(request.TaxiSelectionCriteria);
        }
    }
}