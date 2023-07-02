using View.Models;

namespace View.Domain
{
    internal class ConfirmTrip
    {
        private readonly IHttpRepository _httpRepository;

        internal ConfirmTrip(IHttpRepository httpRepository)
        {
            this._httpRepository = httpRepository;
        }

        internal Trip Invoke(TaxiFound taxiFound, string destinationAddress)
        {
            ConfirmTaxiRequest request = new ConfirmTaxiRequest()
            {
                TaxiFound = taxiFound,
                destinationAddress = destinationAddress
            };

            return this._httpRepository.Put<Trip, ConfirmTaxiRequest>("Selector", request);
        }
    }
}