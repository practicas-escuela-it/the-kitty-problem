using Controller;
using Model;

namespace View
{
    internal class MainView
    {
        private TaxiFinderView _taxiFinderView;

        public MainView()
        {
            this._taxiFinderView = new TaxiFinderView();
        }

        internal void Interact()
        {
            Console.WriteLine("1- Buscar taxi");
            Console.WriteLine("2- Cerrar aplicación");

            if (Console.ReadLine() == "1")
            {
                this._taxiFinderView.Interact();
                List<TaxiDTO> taxis = this._taxiFinderView.GetTaxiFound();

                foreach (TaxiDTO taxi in taxis)
                {
                    Console.WriteLine($"Taxi encontrado: {taxi.Name} - ${taxi.Price}");
                }

                Console.WriteLine("1- Reservar");
                Console.WriteLine("2- Cancelar");

                if (Console.ReadLine() == "1")
                {
                    new TaxiSelector(this.GetSelectedTaxi()).Select();
                }
            }
        }

        private Taxi GetSelectedTaxi()
        {
            return new Taxi();
        }
    }
}