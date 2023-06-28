using Model;

namespace Repository
{
    public interface TaxiRepository
    {
        IEnumerable<Taxi> GetAll();
        IEnumerable<Taxi> GetBySupplier(int supplierId);
    }
}