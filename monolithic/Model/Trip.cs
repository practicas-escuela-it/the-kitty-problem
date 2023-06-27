using Model;

namespace Model
{
    public class Trip
    {
        public int TripId { get; set; }
        public int TaxiId { get; set; }
        public string DestinationAddress { get; set; }
        public double TheoricalPrice { get; set; }
    }
}