﻿using Controller.Models;
using Shared;

namespace Controller
{
    public class TaxiSelector
    {
        private TaxiFound _taxiSelected;
        private IEnumerable<TaxiFound> _taxiFounds;
        private TaxiSelectionCriteria _criteria;

        public TaxiSelector()
        {
        }

        public TaxiFound Select(IEnumerable<TaxiFound> taxiFounds, TaxiSelectionCriteria criteria)
        {
            Assert.NotNull(taxiFounds);
            Assert.NotNull(criteria);

            this._taxiFounds = taxiFounds;
            this._criteria = criteria;
            this._taxiSelected = this.GetTaxiCandidate();
            return this._taxiSelected;
        }

        public void Unselect()
        {
            this._taxiSelected = null;
        }

        private TaxiFound GetTaxiCandidate()
        {
            // ¿Pasar a Chan of Responsability?

            List<TaxiFound> rett = this._taxiFounds.ToList();

            if (this._criteria.IsCatRequired)
            {
                rett = this._taxiFounds.Where(x => x.AcceptCat).ToList();
            }

            if (this._criteria.IsPremiumCar)
            {
                rett = rett.Where(x => x.IsPremium).ToList();
            }

            return rett.First();
        }
    }
}