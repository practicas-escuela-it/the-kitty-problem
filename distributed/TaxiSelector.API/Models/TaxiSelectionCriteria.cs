namespace TaxiSelector.API.Models
{
    public class TaxiSelectionCriteria
    {
        public TaxiSelectionCriteria()
        {

        }

        public int UserId { get; set; }
        public string DestinationAddress { get; set; }
        public bool IsCatRequired { get; set; }
        public bool IsPremiumCar { get; set; }
    }
}