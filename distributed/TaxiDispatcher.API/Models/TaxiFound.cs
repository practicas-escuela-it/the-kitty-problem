namespace TaxiDispatcher.API.Models
{
    public class TaxiFound
    {
        public int Id { get; set; }
        public object Name { get; set; }
        public double Price { get; set; }
        public bool AcceptCat { get; set; }
        public bool IsPremium { get; set; }
    }
}