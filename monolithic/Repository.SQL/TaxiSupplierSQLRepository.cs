using Model;

namespace Repository.SQL
{
    public class TaxiSupplierSQLRepository : TaxiSupplierRepository
    {
        private List<TaxiSupplier> _mock;

        public TaxiSupplierSQLRepository()
        {
            this._mock = new List<TaxiSupplier>()
            {
                new TaxiSupplier() {Id = 1, Name = "Supplier 1", IsAvailable = true},
                new TaxiSupplier() {Id = 2, Name = "Supplier 2", IsAvailable = false},
                new TaxiSupplier() {Id = 3, Name = "Supplier 3", IsAvailable = false},
                new TaxiSupplier() {Id = 4, Name = "Supplier 4", IsAvailable = true},
                new TaxiSupplier() {Id = 5, Name = "Supplier 5", IsAvailable = true}
            };
        }

        public IEnumerable<TaxiSupplier> GetAllAvailable()
        {
            return this._mock.Where(x => x.IsAvailable);
        }

        public void UpdateTaxiAvailability(int taxiId, bool isAvailable)
        {
            this._mock.First(x => x.Id == taxiId).IsAvailable = isAvailable;
        }
    }
}