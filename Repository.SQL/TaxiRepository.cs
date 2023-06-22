using Model;

namespace Repository.SQL
{
    public class TaxiRepository : Repository.TaxiRepository
    {
        public List<Taxi> GetTaxis()
        {
            string query = "SELECT * FROM Taxis";
            throw new NotImplementedException();
        }
    }
}