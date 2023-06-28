using Model;

namespace Repository
{
    public interface TripRepository
    {
        void Insert(Trip trip);
        Trip Get(int id);
    }
}