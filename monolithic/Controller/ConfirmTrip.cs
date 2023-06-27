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

        public void Invoke(TaxiFound taxiFound)
        {
            var trip = new Trip()
            {
                TripId = 1,
                TaxiId = taxiFound.Id,
            };
            this._tripRepository.Insert(trip);
        }
    }
}