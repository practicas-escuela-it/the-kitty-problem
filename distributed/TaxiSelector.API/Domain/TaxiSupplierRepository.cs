using TaxiFinder.API.Models;

namespace TaxiSelector.API.Domain
{
    public interface TaxiSupplierRepository
    {
        List<TaxiSupplier> GetAllAvailable();
        void UpdateTaxiAvailability(int taxiId, bool isAvailable);
    }
}