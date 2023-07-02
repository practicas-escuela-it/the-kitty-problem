using View.Models;

namespace View
{
    internal class TripView
    {
        private readonly Trip _trip;

        public TripView(Trip trip)
        {
            this._trip = trip;
        }

        public void Interact()
        {
            Console.WriteLine("Detalle del viaje:");
            Console.WriteLine($"Destino: {this._trip.DestinationAddress}");
            Console.WriteLine($"Precio teórico: {this._trip.TheoricalPrice}");
        }
    }
}