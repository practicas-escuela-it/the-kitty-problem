using Model;

namespace Repository
{
    public interface TaxiFinderRepository
    {
        List<Taxi> GetAll();
        List<Taxi> GetBySupplier(int supplierId);
    }
}