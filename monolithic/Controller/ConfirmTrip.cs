using Controller.Models;
using Model;
using Repository;
using Shared;

namespace Controller
{
    public class ConfirmTrip
    {
        private readonly TripRepository _tripRepository;

        public ConfirmTrip(TripRepository tripRepository)
        {
            Assert.NotNull(tripRepository);
            this._tripRepository = tripRepository;
        }

        public Trip Confirm(TaxiFound taxiFound, string destinationAddress)
        {
            // Pasar a builder
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

        public Trip GetTrip(int id)
        {
            return this._tripRepository.Get(id);
        }
    }
}