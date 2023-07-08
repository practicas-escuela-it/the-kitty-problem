using Shared.Models;

namespace Shared.Domain
{
    // ¿O generamos 2 repositories (1 en cada microservicio)? Uno tiene el 'Get' y el otro el 'Add'
    public interface CandidateTaxisRepository
    {
        void Add(CandidateTaxi[] candidateTaxis);
        CandidateTaxi[] Get(int userId);
    }
}