using Controller;
using Controller.Models;
using Shared;

namespace View
{
    public class TaxiFinderView
    {
        private TaxiFinder _taxFinder;
        private IEnumerable<TaxiFound> _taxisFound;

        public TaxiFinderView(TaxiFinder taxiFinder)
        {
            Assert.NotNull(taxiFinder);
            this._taxFinder = taxiFinder;
        }

        internal void Interact()
        {          
            this._taxisFound = this._taxFinder.Invoke();
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