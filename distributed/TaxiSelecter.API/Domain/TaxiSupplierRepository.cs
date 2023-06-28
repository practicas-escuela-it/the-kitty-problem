using TaxiFinder.API.Models;

namespace TaxiSelecter.API.Domain
{
    public interface TaxiSupplierRepository
    {
        List<TaxiSupplier> GetAllAvailable();
        void UpdateTaxiAvailability(int taxiId, bool isAvailable);
    }
}