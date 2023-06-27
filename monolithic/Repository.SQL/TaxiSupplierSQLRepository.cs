using Model;

namespace Repository.SQL
{
    public class TaxiSupplierSQLRepository : TaxiSupplierRepository
    {
        public List<TaxiSupplier> GetAllAvailable()
        {
            string query = "SELECT * FROM TaxiSuppliers WHERE IsAvailable = true";
            return new List<TaxiSupplier>();
        }

        public void UpdateTaxiAvailability(int taxiId, bool isAvailable)
        {
            string query = $"UPDATE FROM Taxi SET IsAvailable = {isAvailable} WHERE Id = {taxiId}";
        }
    }
}