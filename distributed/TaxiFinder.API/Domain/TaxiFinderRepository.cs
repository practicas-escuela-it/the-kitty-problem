namespace TaxiFinder.API.Domain
{
    public interface TaxiFinderRepository
    {
        List<Taxi> GetAl();
        List<Taxi> GetBySupplier(int supplierId);
    }
}