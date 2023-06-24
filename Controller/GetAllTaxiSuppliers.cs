using Model;

namespace Controller
{
    public class GetAllTaxiSuppliers
    {
        public List<TaxiSupplier> Invoke()
        {
            string query = "SELECT * FROM TaxiSupplier";
            return new List<TaxiSupplier>();
        }
    }
}