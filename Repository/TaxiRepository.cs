using Controller.Repositories;
using Model;

namespace Repository
{
    public class TaxiRepository : TaxiGetter
    {
        public List<Taxi> GetTaxis()
        {
            string query = "SELECT * FROM Taxis";
            throw new NotImplementedException();
        }
    }
}