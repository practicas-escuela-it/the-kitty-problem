using CandidateTaxi.Repository.SQL;

namespace CandidateTaxi.Domain
{
    public class AddCandidateTaxis
    {
        private readonly CandidateTaxisRepository _candidateTaxisRepository;

        public AddCandidateTaxis()
        {
            this._candidateTaxisRepository = new CandidateTaxisSQLRepository();
        }

        public void Add(Models.CandidateTaxi[] candidateTaxis)
        {
            this._candidateTaxisRepository.Add(candidateTaxis);
        }
    }
}