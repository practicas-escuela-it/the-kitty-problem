using TaxiFinder.API.Models;
using TaxiFinder.API.Repository.SQL;

namespace TaxiFinder.API.Domain
{
    public class GetTaxiSuppliers
    {
        private readonly TaxiSupplierRepository _taxiSupplierRepository;

        public GetTaxiSuppliers()
        {
            this._taxiSupplierRepository = new TaxiSupplierSQLRepository();
        }

        public TaxiSupplier[] GetAllAvailable()
        {
            return this._taxiSupplierRepository.GetAllAvailable();
        }
    }
}