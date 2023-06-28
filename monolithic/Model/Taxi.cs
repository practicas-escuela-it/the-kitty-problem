namespace Model
{
    public class Taxi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public bool IsAvailable { get; set; }
        public bool IsPremium { get; set; }
        public int SupplierId { get; set; }
        public bool AcceptCat { get; set; }
    }
}