using Controller.Models;
using Shared;

namespace Controller
{
    public class TaxiSelector
    {
        private TaxiFound _taxiSelected;
        private IEnumerable<TaxiFound> _taxiFounds;
        private TaxiSelectionCriteria _criteria;
        private readonly TaxiDispatcher _taxiDispatcher;

        public TaxiSelector(TaxiDispatcher taxiDispatcher)
        {
            this._taxiDispatcher = taxiDispatcher;
        }

        public TaxiFound Select(IEnumerable<TaxiFound> taxiFounds, TaxiSelectionCriteria criteria)
        {
            Assert.NotNull(taxiFounds);
            Assert.NotNull(criteria);

            this._taxiFounds = taxiFounds;
            this._criteria = criteria;
            this._taxiSelected = this.GetTaxiCandidate();
            this._taxiDispatcher.HandsTaxiOff(this._taxiSelected);
            return this._taxiSelected;
        }

        public void Unselect()
        {
            this._taxiSelected = null;
        }

        private TaxiFound GetTaxiCandidate()
        {
            // ¿Pasar a Chan of Responsability?

            List<TaxiFound> result = this._taxiFounds.ToList();

            if (this._criteria.IsCatRequired)
            {
                result = this._taxiFounds.Where(x => x.AcceptCat).ToList();
            }

            if (this._criteria.IsPremiumCar)
            {
                result = result.Where(x => x.IsPremium).ToList();
            }

            return result.First();
        }
    }
}