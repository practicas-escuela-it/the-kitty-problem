using Controller.Models;
using Model;
using Repository;

namespace Controller
{
    public class TaxiFinder
    {
        private readonly TaxiRepository _taxiRepository;
        private readonly TaxiSupplierRepository _taxiSupplierRepository;

        public TaxiFinder(TaxiRepository repository, TaxiSupplierRepository taxiSupplierRepository)
        {
            this._taxiRepository = repository;
            this._taxiSupplierRepository = taxiSupplierRepository;
        }

        public IEnumerable<TaxiFound> Invoke()
        {
            List<Taxi> list = new List<Taxi>();
            foreach (TaxiSupplier supplier in this._taxiSupplierRepository.GetAllAvailable())
            {
                list.AddRange(this._taxiRepository.GetBySupplier(supplier.Id));
            }
            return list.Select(x => new TaxiFound(x));
        }
    }
}