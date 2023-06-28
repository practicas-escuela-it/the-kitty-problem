using TaxiSelecter.API.Domain;

namespace TaxiFinder.API.Domain
{
    public class TaxiDispatcher
    {
        private readonly TaxiSupplierRepository _taxiSupplierRepository;

        public TaxiDispatcher(TaxiSupplierRepository taxiSupplierRepository)
        {
            this._taxiSupplierRepository = taxiSupplierRepository;
        }

        public void HandsTaxiOff(TaxiFound taxiFound)
        {
            this.DisableTaxi(taxiFound);
        }

        private void DisableTaxi(TaxiFound taxiFound)
        {
            this._taxiSupplierRepository.UpdateTaxiAvailability(taxiFound.Id, false);
        }

        private void EnableTaxi(TaxiFound taxiFound)
        {
            this._taxiSupplierRepository.UpdateTaxiAvailability(taxiFound.Id, true);
        }
    }
}