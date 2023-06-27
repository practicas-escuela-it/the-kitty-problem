namespace TaxiFinder.API.Domain
{
    public class TaxiFinderService
    {
        private readonly TaxiFinderRepository _taxiFinderRepository;

        public TaxiFinderService(TaxiFinderRepository taxiFinderRepository)
        {
            this._taxiFinderRepository = taxiFinderRepository;
        }

        public void Get()
        {
            List<Taxi> list = new List<Taxi>();
            foreach (TaxiSupplier supplier in this._taxiSupplierRepository.GetAllAvailable())
            {
                list.AddRange(this._taxiFinderRepository.GetBySupplier(supplier.Id));
            }
            return list.Select(x => new TaxiFound(x));
        }
    }
}