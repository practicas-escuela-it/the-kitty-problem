using Microsoft.AspNetCore.Mvc;
using TaxiDispatcher.API.Models;

namespace TaxiDispatcher.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfirmTripController : ControllerBase
    {
        private readonly Domain.ConfirmTrip _confirmTrip;

        internal ConfirmTripController(Domain.ConfirmTrip confirmTrip)
        {
            this._confirmTrip = confirmTrip;
        }

        [HttpPut]
        public Trip Confirm(TaxiFound taxiFound, string destinationAddress)
        {
            return this._confirmTrip.Invoke(taxiFound, destinationAddress);
        }
    }
}