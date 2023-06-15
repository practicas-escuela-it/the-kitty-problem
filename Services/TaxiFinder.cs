using Controller.Repositories;

namespace Controller
{
    public class TaxiFinder
    {
        private readonly TaxiGetter _taxiGetter;

        public TaxiFinder(TaxiGetter taxiGetter)
        {
            this._taxiGetter = taxiGetter;
        }

        public List<TaxiDTO> Find(string? destination, bool withCat)
        {
            if (destination is null)
            {
                throw new ArgumentException("");
            }

            if (withCat)
            {
                this._taxiGetter.GetTaxis();
            }
            else
            {
                // call service 2
            }


            return null;
        }
    }
}