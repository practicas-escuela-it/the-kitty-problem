using View.Models;

namespace View.Domain
{
    internal class TaxiSelector
    {
        private readonly IHttpRepository _httpRepository;

        public TaxiSelector(IHttpRepository httpRepository)
        {
            this._httpRepository = httpRepository;
        }

        internal TaxiFound Select(IEnumerable<TaxiFound> taxiFounds, TaxiSelectionCriteria taxiSelectionCriteria)
        {
            TaxiSelectorRequest request = new TaxiSelectorRequest()
            {
                TaxiFounds = taxiFounds,
                TaxiSelectionCriteria = taxiSelectionCriteria
            };

            return this._httpRepository.Get<TaxiFound, TaxiSelectorRequest>("Selector", request);
        }
    }
}