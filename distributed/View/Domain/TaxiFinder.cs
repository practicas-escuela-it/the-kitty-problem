using View.Models;

namespace View.Domain
{
    internal class TaxiFinder
    {
        private readonly TaxiRepository _taxiRepository;

        internal TaxiFinder(TaxiRepository taxiRepository)
        {
            this._taxiRepository = taxiRepository;
        }

        internal IEnumerable<TaxiFound> Invoke()
        {
            // TODO - ¿cómo se puede mejorar este código?
            // en el libro plantea guardar este resultado en una memoria caché y que el servicio de TaxiSelector lo ela directo de allí
            return this._taxiRepository.Get<IEnumerable<TaxiFound>>("Finder");
        }
    }
}