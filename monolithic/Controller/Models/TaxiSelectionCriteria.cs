namespace Controller.Models
{
    public class TaxiSelectionCriteria
    {
        public TaxiSelectionCriteria()
        {

        }
        public string DestinationAddress { get; set; }
        public bool IsCatRequired { get; set; }
        public bool IsPremiumCar { get; set; }
    }
}