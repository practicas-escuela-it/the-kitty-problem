using Controller;
using Repository;

namespace View
{
    public class TaxiFinderView
    {
        private TaxiFinder _taxFinder;
        private List<TaxiDTO> _taxisFound;

        public TaxiFinderView()
        {
            this._taxFinder = new TaxiFinder(new TaxiRepository());
        }

        internal void Interact()
        {
            Console.WriteLine("Ingresá tu destino");
            string? destination = Console.ReadLine();

            Console.WriteLine("¿Vas con gato?");
            bool withCat = Console.ReadLine() == "S";

            this._taxisFound = this._taxFinder.Find(destination, withCat);
            Console.WriteLine("Taxis encontrados:");

            foreach (TaxiDTO taxi in this._taxisFound)
            {
                Console.WriteLine($"{taxi.Name} - ${taxi.Price}");
            }
        }

        internal bool IsTaxiSelected()
        {
            return this._taxisFound.Any();
        }

        internal List<TaxiDTO> GetTaxiFound()
        {
            return this._taxisFound;
        }
    }
}