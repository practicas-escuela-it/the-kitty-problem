using TaxiFinder.API.Models;

namespace TaxiFinder.API.Domain
{
    public interface TaxiSupplierRepository
    {
        TaxiSupplier[] GetAllAvailable();
        void UpdateTaxiAvailability(int taxiId, bool isAvailable);
    }
}