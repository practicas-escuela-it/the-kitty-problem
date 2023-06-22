using Repository;

namespace Controller
{
    public class TaxiFinder
    {
        private readonly TaxiRepository _repository;

        public TaxiFinder(TaxiRepository repository)
        {
            this._repository = repository;
        }

        public List<TaxiDTO> Find(string? destination, bool withCat)
        {
            if (destination is null)
            {
                throw new ArgumentException("");
            }

            if (withCat)
            {
                this._repository.GetTaxis();
            }
            else
            {
                // call service 2
            }


            return null;
        }
    }
}