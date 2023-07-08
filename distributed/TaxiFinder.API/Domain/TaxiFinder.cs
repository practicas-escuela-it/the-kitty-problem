using Shared.Domain;
using Shared.Models;
using TaxiFinder.API.Models;

namespace TaxiFinder.API.Domain
{
    public class TaxiFinder
    {
        private readonly TaxiFinderRepository _taxiFinderRepository;
        private readonly GetTaxiSuppliers _getTaxiSuppliers;
        private readonly AddCandidateTaxis _addCandidateTaxis;

        public TaxiFinder(TaxiFinderRepository taxiFinderRepository)
        {
            this._taxiFinderRepository = taxiFinderRepository;
            this._addCandidateTaxis = new AddCandidateTaxis();
            this._getTaxiSuppliers = new GetTaxiSuppliers();
        }

        public void Find(int userId)
        {
            List<CandidateTaxi> result = new List<CandidateTaxi>();
            foreach (TaxiSupplier supplier in this._getTaxiSuppliers.GetAllAvailable())
            {
                foreach (Taxi taxi in this._taxiFinderRepository.GetBySupplier(supplier.Id))
                {
                    result.Add(this.ToCandidateTaxi(taxi, supplier, userId));
                }
            }
            this._addCandidateTaxis.Add(result.ToArray());
        }

        private CandidateTaxi ToCandidateTaxi(Taxi taxi, TaxiSupplier supplier, int userId)
        {
            // ¿Lo construimos de esta manera o hacemos que el constructor reciba un Taxi y se costruya en un estado válido?
            // Deberíamos mover Taxi a Shared.Models
            return new CandidateTaxi
            {
                TaxiId = taxi.Id,
                UserId = userId,
                SupplierId = supplier.Id,
            };
        }
    }
}