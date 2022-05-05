using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;
using UOW.Data;

namespace UOW.Repository
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly UowDbContext _dbContext;
        private readonly ILogger _logger;

        public ILeagueRepository League { get; private set; }

        public ITeamRepository Team { get; private set; }

        public IPlayerRepository Player { get; private set; }

        public UnitOfWork(UowDbContext dbContext, ILoggerFactory loggerFactory)
        {
            _dbContext = dbContext;
            _logger = loggerFactory.CreateLogger("logs");

            League = new LeagueRepository(dbContext, _logger);
            Team = new TeamRepository(dbContext, _logger);
            Player = new PlayerRepository(dbContext, _logger);
        }

        public async Task CommitAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            _dbContext.Dispose();
        }
    }
}
