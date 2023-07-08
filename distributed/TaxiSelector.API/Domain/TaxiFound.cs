using Shared.Models;

namespace TaxiSelector.API.Domain
{
    public class TaxiFound
    {
        public TaxiFound(CandidateTaxi candidateTaxi)
        {
            this.Id = candidateTaxi.TaxiId;
            this.AcceptCat = candidateTaxi.AcceptCat;
            this.IsPremium = candidateTaxi.IsPremium;
        }

        public int Id { get; set; }
        public object Name { get; set; }
        public double Price { get; set; }
        public bool AcceptCat { get; set; }
        public bool IsPremium { get; set; }
    }
}