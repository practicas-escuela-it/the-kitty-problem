using TaxiFinder.API.Models;

namespace TaxiFinder.API.Domain
{
    public class TaxiFinderService
    {
        private readonly TaxiFinderRepository _taxiFinderRepository;
        private readonly TaxiSupplierRepository _taxiSupplierRepository;

        public TaxiFinderService(TaxiFinderRepository taxiFinderRepository)
        {
            this._taxiFinderRepository = taxiFinderRepository;
        }

        public IEnumerable<TaxiFound> Invoke()
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