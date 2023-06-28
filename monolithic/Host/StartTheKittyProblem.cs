using Controller;
using Repository.SQL;
using View;

namespace Host
{
    public class StartTheKittyProblem
    {
        public void Start()
        {
            Do();
        }

        private void Do()
        {
            TaxiFinder taxiFinder = new TaxiFinder(new TaxiSQLRepository(), new TaxiSupplierSQLRepository());
            TaxiSelector taxiSelector = new TaxiSelector(new TaxiDispatcher(new TaxiSupplierSQLRepository()));
            ConfirmTrip confirmTrip = new ConfirmTrip(new TripSQLRepository());
            new MainView(taxiFinder, taxiSelector, confirmTrip).Interact();
        }
    }
}