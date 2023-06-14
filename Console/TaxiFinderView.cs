using Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View
{
    internal class TaxiFinderView
    {
        private TaxiFinder _taxFinder;
        private List<Taxi> _taxisFound;

        public TaxiFinderView()
        {
            this._taxFinder = new TaxiFinder();
        }

        internal void Interact()
        {
            Console.WriteLine("Ingresá tu destino");
            string? destination = Console.ReadLine();

            Console.WriteLine("¿Vas con gato?");
            bool withCat = Console.ReadLine() == "S";

            this._taxisFound = this._taxFinder.Find(destination, withCat);
            Console.WriteLine("Taxis encontrados:");

            foreach (Taxi taxi in this._taxisFound)
            {
                Console.WriteLine($"{taxi.Name} - ${taxi.Price}");
            }
        }

        internal bool IsTaxiSelected()
        {
            return this._taxisFound.Any();
        }

        internal List<Taxi> GetTaxiFound()
        {
            return this._taxisFound;
        }
    }
}