using Model;

namespace Repository.SQL
{
    public class TaxiSQLRepository : TaxiRepository
    {
        private List<Taxi> _mock;

        public TaxiSQLRepository()
        {
            _mock = new List<Taxi>() {
                new Taxi(){  Id=1, Name="Taxi 1", IsAvailable=true, Price=12, IsPremium=true, SupplierId=1, AcceptCat = true},
                new Taxi(){  Id=2, Name="Taxi 2", IsAvailable=true, Price=10, IsPremium=false, SupplierId=1, AcceptCat = false},
                new Taxi(){  Id=3, Name="Taxi 3", IsAvailable=false, Price=10, IsPremium=false, SupplierId=3, AcceptCat = true},
                new Taxi(){  Id=4, Name="Taxi 4", IsAvailable=true, Price=12, IsPremium=true, SupplierId=3, AcceptCat = true},
            };
        }
        public IEnumerable<Taxi> GetAll()
        {
            string query = "SELECT * FROM Taxis";
            return this._mock;
        }

        public IEnumerable<Taxi> GetBySupplier(int supplierId)
        {
            string query = $"SELECT * FROM Taxis WHERE SupplierId = {supplierId}";
            return this._mock.Where(x => x.SupplierId == supplierId);
        }
    }
}