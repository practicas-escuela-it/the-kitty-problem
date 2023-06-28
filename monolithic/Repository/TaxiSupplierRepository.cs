using Model;

namespace Repository
{
    public interface TaxiSupplierRepository
    {
        IEnumerable<TaxiSupplier> GetAllAvailable();
        void UpdateTaxiAvailability(int taxiId, bool isAvailable);
    }
}