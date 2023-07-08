using Microsoft.AspNetCore.Mvc;
using TaxiDispatcher.API.Models;

namespace TaxiDispatcher.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderTaxiController : ControllerBase
    {
        private readonly Domain.ConfirmTrip _confirmTrip;

        internal OrderTaxiController(Domain.ConfirmTrip confirmTrip)
        {
            this._confirmTrip = confirmTrip;
        }

        [HttpPut]
        public Trip OrderTaxi(TaxiFound taxiFound, string destinationAddress)
        {
            return this._confirmTrip.Confirm(taxiFound, destinationAddress);
        }
    }
}