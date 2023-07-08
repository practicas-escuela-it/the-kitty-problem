using TaxiFinder.API.Domain;
using TaxiFinder.API.Models;

namespace TaxiFinder.API.Repository.SQL
{
    public class TaxiSupplierSQLRepository : TaxiSupplierRepository
    {
        private static TaxiSupplier[] _mock;

        public TaxiSupplierSQLRepository()
        {
            TaxiSupplier supplier1 = new TaxiSupplier(1);
            TaxiSupplier supplier2 = new TaxiSupplier(2);
            _mock = new TaxiSupplier[] { supplier1, supplier2 };
        }

        public TaxiSupplier[] GetAllAvailable()
        {
            return _mock;
        }

        public void UpdateTaxiAvailability(int taxiId, bool isAvailable)
        {
            throw new NotImplementedException();
        }
    }
}