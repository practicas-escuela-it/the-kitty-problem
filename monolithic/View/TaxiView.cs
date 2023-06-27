using Controller.Models;

namespace View
{
    public class TaxiView
    {
        private readonly TaxiFound _taxi;

        public TaxiView(TaxiFound taxi)
        {
            this._taxi = taxi;
        }

        public void Interact()
        {
            Console.WriteLine($"{this._taxi.Name} - ${this._taxi.Price}");
        }
    }
}