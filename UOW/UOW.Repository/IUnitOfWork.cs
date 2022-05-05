using System.Threading.Tasks;

namespace UOW.Repository
{
    public interface IUnitOfWork
    {
        ILeagueRepository League { get; }
        ITeamRepository Team { get; }
        IPlayerRepository Player { get; }
        Task CommitAsync();
    }
}
