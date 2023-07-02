using View.Models;

namespace View
{
    internal class TaxiView
    {
        private readonly TaxiFound _taxi;

        internal TaxiView(TaxiFound taxi)
        {
            this._taxi = taxi;
        }

        internal void Interact()
        {
            Console.WriteLine($"{this._taxi.Name} - ${this._taxi.Price}");
        }
    }
}