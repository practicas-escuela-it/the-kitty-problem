using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            Console.WriteLine("1- Cerrar aplicación");

            if (Console.ReadLine() == "1")
            {
                this._taxiFinderView.Interact();
                List<Taxi> taxis = this._taxiFinderView.GetTaxiFound();

                Console.WriteLine($"Taxi encontrado: {taxi.Name} - ${taxi.Price}");
                Console.WriteLine("1- Reservar");
                Console.WriteLine("2- Cancelar");
                if (Console.ReadLine() == "1")
                {
                    new TaxiSelector(taxi).Select();
                }
            }
        }
    }
}
