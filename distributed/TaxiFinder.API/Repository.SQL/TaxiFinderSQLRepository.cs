using TaxiFinder.API.Domain;
using TaxiFinder.API.Models;

namespace TaxiFinder.API.Repository.SQL
{
    public class TaxiFinderSQLRepository : TaxiFinderRepository
    {
        public List<Taxi> GetAll()
        {
            string query = "SELECT * FROM Taxis";
            return this.GetMock();
        }

        public List<Taxi> GetBySupplier(int supplierId)
        {
            string query = $"SELECT * FROM Taxis WHERE SupplierId = {supplierId}";
            return this.GetMock();
        }

        private List<Taxi> GetMock()
        {
            return new List<Taxi>() {
                new Taxi(){  Id=1, Name="Taxi 1", IsAvailable=true, Price=10, IsPremium=false, AcceptCat=true},
                new Taxi(){  Id=2, Name="Taxi 2", IsAvailable=true, Price=10, IsPremium=false, AcceptCat=true},
                new Taxi(){  Id=3, Name="Taxi 3", IsAvailable=false, Price=10, IsPremium=false, AcceptCat=true},
                new Taxi(){  Id=4, Name="Taxi 4", IsAvailable=true, Price=12, IsPremium=true, AcceptCat=true},
            };
        }
    }
}