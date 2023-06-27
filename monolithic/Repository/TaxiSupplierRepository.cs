using Model;

namespace Repository
{
    public interface TaxiSupplierRepository
    {
        List<TaxiSupplier> GetAllAvailable();
        void UpdateTaxiAvailability(int taxiId, bool isAvailable);
    }
}