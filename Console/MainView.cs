using Controller;

namespace View
{
    public class MainView
    {
        private readonly TaxiFinderView _taxiFinderView;
        private readonly TaxiSelectorView _taxiSelectorView;

        public MainView(TaxiFinder taxiFinder, TaxiSelector taxiSelector, ConfirmTrip confirmTrip)
        {
            this._taxiFinderView = new TaxiFinderView(taxiFinder);
            this._taxiSelectorView = new TaxiSelectorView(taxiSelector, confirmTrip);
        }

        public void Interact()
        {
            Console.WriteLine("1- Buscar taxi");
            Console.WriteLine("2- Cerrar aplicación");

            if (Console.ReadLine() == "1")
            {
                this._taxiFinderView.Interact();
                this._taxiSelectorView.Interact(this._taxiFinderView.GetTaxiFound());
            }
        }
    }
}