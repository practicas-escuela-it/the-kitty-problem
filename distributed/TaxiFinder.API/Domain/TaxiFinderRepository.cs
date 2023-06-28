using TaxiFinder.API.Models;

namespace TaxiFinder.API.Domain
{
    public interface TaxiFinderRepository
    {
        List<Taxi> GetAll();
        List<Taxi> GetBySupplier(int supplierId);
    }
}