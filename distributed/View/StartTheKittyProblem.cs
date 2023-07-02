using View.Domain;
using View.Insfractuture;

namespace View
{
    public class StartTheKittyProblem
    {
        public void Start()
        {
            HttpRepository repository = new HttpRepository("http://localhost:84447/api/");

            TaxiFinder taxiFinder = new TaxiFinder(repository);
            TaxiSelector taxiSelector = new TaxiSelector(repository);
            ConfirmTrip confirmTrip = new ConfirmTrip(repository);
            new MainView(taxiFinder, taxiSelector, confirmTrip).Interact();
        }
    }
}