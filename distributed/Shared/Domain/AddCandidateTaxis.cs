using Shared.Models;
using Shared.Repository.SQL;

namespace Shared.Domain
{
    public class AddCandidateTaxis
    {
        private readonly CandidateTaxisRepository _candidateTaxisRepository;

        public AddCandidateTaxis()
        {
            this._candidateTaxisRepository = new CandidateTaxisSQLRepository();
        }

        public void Add(CandidateTaxi[] candidateTaxis)
        {
            this._candidateTaxisRepository.Add(candidateTaxis);
        }
    }
}