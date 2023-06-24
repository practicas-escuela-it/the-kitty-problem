using Controller;
using Controller.Models;
using Shared;

namespace View
{
    public class TaxiSelectorView
    {
        private readonly TaxiSelector _taxiSelector;
        private readonly ConfirmTrip _confirmTrip;

        public TaxiSelectorView(TaxiSelector taxiSelector, ConfirmTrip confirmTrip)
        {
            Assert.NotNull(taxiSelector);
            Assert.NotNull(confirmTrip);
            this._taxiSelector = taxiSelector;
            this._confirmTrip = confirmTrip;
        }

        internal void Interact(IEnumerable<TaxiFound> taxiFounds)
        {
            TaxiSelectionCriteria criteria = new TaxiSelectionCriteria();

            Console.WriteLine("Ingresá tu destino");
            criteria.DestinationAddress = Console.ReadLine() ?? "";

            Console.WriteLine("¿Vas con gato?");
            criteria.IsCatRequired = Console.ReadLine() == "S";

            Console.WriteLine("¿Coche premium?");
            criteria.IsPremiumCar = Console.ReadLine() == "S";

            TaxiFound taxiFound = _taxiSelector.Select(taxiFounds, criteria);

            Console.WriteLine($"Taxi seleccionado: {taxiFound.Name}");
            Console.WriteLine($"Precio: {taxiFound.Price}");
            Console.WriteLine("¿Desea continuar?");

            if (Console.ReadLine() == "S")
            {
                this._confirmTrip.Invoke(taxiFound);
            }
        }
    }
}