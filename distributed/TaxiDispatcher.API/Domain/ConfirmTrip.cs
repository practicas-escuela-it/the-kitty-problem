using Shared;
using TaxiDispatcher.API.Models;

namespace TaxiDispatcher.API.Domain
{
    internal class ConfirmTrip
    {
        private readonly TripRepository _tripRepository;

        internal ConfirmTrip(TripRepository tripRepository)
        {
            Assert.NotNull(tripRepository);
            this._tripRepository = tripRepository;
        }

        internal Trip Confirm(TaxiFound taxiFound, string destinationAddress)
        {
            Trip trip = new Trip()
            {
                TripId = new Random().Next(100),
                Id = taxiFound.Id,
                DestinationAddress = destinationAddress,
                TheoricalPrice = taxiFound.Price * this.GetDistance(destinationAddress),
            };

            this._tripRepository.Insert(trip);
            return trip;
        }

        private int GetDistance(string destinationAddress)
        {
            return new Random().Next(100);
        }
    }
}
