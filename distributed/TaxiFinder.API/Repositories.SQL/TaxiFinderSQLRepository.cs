namespace TaxiFinder.API.Repositories.SQL
{
    public class TaxiFinderRepository : TaxiFinderRepository
    {
        public List<Taxi> GetAll()
        {
            string query = "SELECT * FROM Taxis";
            return new List<Taxi>();
        }

        public List<Taxi> GetBySupplier(int supplierId)
        {
            string query = $"SELECT * FROM Taxis WHERE SupplierId = {supplierId}";
            return new List<Taxi>();
        }
    }
}