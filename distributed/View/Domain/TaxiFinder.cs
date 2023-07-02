using View.Models;

namespace View.Domain
{
    internal class TaxiFinder
    {
        private readonly IHttpRepository _httpRepository;

        internal TaxiFinder(IHttpRepository httpRepository)
        {
            this._httpRepository = httpRepository;
        }

        internal IEnumerable<TaxiFound> Invoke()
        {
            return this._httpRepository.Get<IEnumerable<TaxiFound>>("Finder");
        }
    }
}