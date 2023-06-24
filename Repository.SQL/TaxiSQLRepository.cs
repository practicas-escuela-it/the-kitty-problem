using Model;

namespace Repository.SQL
{
    public class TaxiSQLRepository : TaxiRepository
    {
        public List<Taxi> GetAll()
        {
            string query = "SELECT * FROM Taxis";
            throw new NotImplementedException();
        }

        public List<Taxi> GetBySupplier(int supplierId)
        {
            string query = $"SELECT * FROM Taxis WHERE SupplierId = {supplierId}";
            throw new NotImplementedException();
        }
    }
}