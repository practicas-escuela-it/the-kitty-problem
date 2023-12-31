﻿using CandidateTaxi.Domain;
using Shared;
using TaxiFinder.API.Domain;
using TaxiSelector.API.Models;

namespace TaxiSelector.API.Domain
{
    internal class TaxiSelector
    {
        private TaxiFound _taxiSelected;
        private TaxiSelectionCriteria _criteria;
        private readonly TaxiDispatcher _taxiDispatcher;
        private readonly GetCandidateTaxis _getCandidateTaxis;

        internal TaxiSelector(TaxiDispatcher taxiDispatcher, GetCandidateTaxis getCandidateTaxis)
        {
            this._taxiDispatcher = taxiDispatcher;
            this._getCandidateTaxis = getCandidateTaxis;
        }

        internal TaxiFound Select(TaxiSelectionCriteria criteria)
        {
            Assert.NotNull(criteria);

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
            IEnumerable<CandidateTaxi.Models.CandidateTaxi> candidateTaxis = this._getCandidateTaxis.Get(this._criteria.UserId);

            if (this._criteria.IsCatRequired)
            {
                candidateTaxis = candidateTaxis.Where(x => x.AcceptCat);
            }

            if (this._criteria.IsPremiumCar)
            {
                candidateTaxis = candidateTaxis.Where(x => x.IsPremium);
            }

            return new TaxiFound(candidateTaxis.First());
        }
    }
}