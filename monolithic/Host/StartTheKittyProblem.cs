using Controller;
using Repository.SQL;
using View;

namespace Host
{
    public class StartTheKittyProblem
    {
        public static void Main()
        {
        }

        public static void Start()
        {
            Do();
        }

        private static void Do()
        {
            TaxiFinder taxiFinder = new TaxiFinder(new TaxiSQLRepository(), new TaxiSupplierSQLRepository());
            TaxiSelector taxiSelector = new TaxiSelector();
            ConfirmTrip confirmTrip = new ConfirmTrip(new TripSQLRepository());
            new MainView(taxiFinder, taxiSelector, confirmTrip).Interact();
        }
    }
}