namespace TaxiFinder.API.Models
{
    public class Taxi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsPremium { get; set; }
    }
}