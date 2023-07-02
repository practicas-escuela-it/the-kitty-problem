using Shared;
using View.Domain;
using View.Models;

namespace View
{
    internal class TaxiSelectorView
    {
        private readonly TaxiSelector _taxiSelector;
        private readonly ConfirmTrip _confirmTrip;

        internal TaxiSelectorView(TaxiSelector taxiSelector, ConfirmTrip confirmTrip)
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
            criteria.IsCatRequired = Console.ReadLine() == "s";

            Console.WriteLine("¿Coche premium?");
            criteria.IsPremiumCar = Console.ReadLine() == "s";

            TaxiFound taxiFound = this._taxiSelector.Select(taxiFounds, criteria);

            Console.WriteLine($"Taxi seleccionado: {taxiFound.Name}");
            Console.WriteLine($"Precio: {taxiFound.Price}");
            Console.WriteLine("¿Desea continuar?");

            if (Console.ReadLine() == "s")
            {
                Trip trip = this._confirmTrip.Invoke(taxiFound, criteria.DestinationAddress);
                new TripView(trip).Interact();
            }
        }
    }
}