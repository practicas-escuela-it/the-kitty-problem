using Shared.Domain;
using Shared.Models;

namespace Shared.Repository.SQL
{
    internal class CandidateTaxisSQLRepository : CandidateTaxisRepository
    {
        private static CandidateTaxi[] _mock;

        public void Add(CandidateTaxi[] candidateTaxis)
        {
            _mock = candidateTaxis;
        }

        public CandidateTaxi[] Get(int userId)
        {
            return _mock.Where(x => x.UserId == userId).ToArray();
        }
    }
}