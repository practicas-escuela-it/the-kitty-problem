using Model;

namespace Repository.SQL
{
    public class TripSQLRepository : TripRepository
    {
        private List<Trip> _mock;

        public TripSQLRepository()
        {
            this._mock = new List<Trip>();
        }

        public Trip Get(int id)
        {
            return this._mock.Where(x => x.Id == id).First();
        }

        public void Insert(Trip trip)
        {
            this._mock.Add(trip);
        }
    }
}