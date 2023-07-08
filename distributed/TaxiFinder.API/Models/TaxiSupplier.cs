namespace TaxiFinder.API.Models
{
    public class TaxiSupplier
    {
        public TaxiSupplier(int id)
        {
            this.Id = id;
        }
        
        public int Id { get; set; }
    }
}