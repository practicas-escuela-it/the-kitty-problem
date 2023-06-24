using Model;

namespace Repository
{
    public interface TaxiRepository
    {
        List<Taxi> GetAll();
        List<Taxi> GetBySupplier(int supplierId);
    }
}