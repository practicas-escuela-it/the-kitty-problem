namespace CandidateTaxi.Domain
{
    // ¿O generamos 2 repositories (1 en cada microservicio)? Uno tiene el 'Get' y el otro el 'Add'
    public interface CandidateTaxisRepository
    {
        void Add(Models.CandidateTaxi[] candidateTaxis);
        Models.CandidateTaxi[] Get(int userId);
    }
}