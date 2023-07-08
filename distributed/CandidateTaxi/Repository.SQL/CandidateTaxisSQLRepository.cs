using CandidateTaxi.Domain;

namespace CandidateTaxi.Repository.SQL
{
    internal class CandidateTaxisSQLRepository : CandidateTaxisRepository
    {
        private static Models.CandidateTaxi[] _mock;

        public void Add(Models.CandidateTaxi[] candidateTaxis)
        {
            _mock = candidateTaxis;
        }

        public Models.CandidateTaxi[] Get(int userId)
        {
            return _mock.Where(x => x.UserId == userId).ToArray();
        }
    }
}