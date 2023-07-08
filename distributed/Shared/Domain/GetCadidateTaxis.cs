using Shared.Models;
using Shared.Repository.SQL;

namespace Shared.Domain
{
    public class GetCandidateTaxis
    {
        private readonly CandidateTaxisRepository _candidateTaxisRepository;

        public GetCandidateTaxis()
        {
            this._candidateTaxisRepository = new CandidateTaxisSQLRepository();
        }

        public CandidateTaxi[] Get(int userId)
        {
            return this._candidateTaxisRepository.Get(userId);
        }
    }
}