namespace Shared.Models
{
    public class CandidateTaxi
    {
        public int TaxiId { get; set; }
        public int SupplierId { get; set; }
        public int UserId { get; set; }
        public bool AcceptCat { get; set; }
        public bool IsPremium { get; set; }
    }
}