using TaxiDispatcher.API.Models;

namespace TaxiDispatcher.API.Domain
{
    internal interface TripRepository
    {
        void Insert(Trip trip);
        Trip Get(int id);
    }
}