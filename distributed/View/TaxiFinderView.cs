using Shared;
using View.Domain;
using View.Models;

namespace View
{
    internal class TaxiFinderView
    {
        private IEnumerable<TaxiFound> _taxisFound;
        private readonly TaxiFinder _taxiFinder;

        internal TaxiFinderView(TaxiFinder taxiFinder)
        {
            Assert.NotNull(taxiFinder);
            this._taxiFinder = taxiFinder;
        }

        internal void Interact()
        {
            this._taxisFound = this._taxiFinder.Invoke();
            Console.WriteLine("Taxis encontrados:");
            foreach (TaxiFound taxi in this._taxisFound)
            {
                new TaxiView(taxi).Interact();
            }
        }

        internal bool IsTaxiSelected()
        {
            return this._taxisFound.Any();
        }

        internal IEnumerable<TaxiFound> GetTaxiFound()
        {
            return this._taxisFound;
        }
    }
}