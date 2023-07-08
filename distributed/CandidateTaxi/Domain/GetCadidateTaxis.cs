using CandidateTaxi.Repository.SQL;

namespace CandidateTaxi.Domain
{
    public class GetCandidateTaxis
    {
        private readonly CandidateTaxisRepository _candidateTaxisRepository;

        public GetCandidateTaxis()
        {
            this._candidateTaxisRepository = new CandidateTaxisSQLRepository();
        }

        public Models.CandidateTaxi[] Get(int userId)
        {
            return this._candidateTaxisRepository.Get(userId);
        }
    }
}