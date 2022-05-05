using Microsoft.Extensions.Logging;
using UOW.Data;
using UOW.Data.Entities;

namespace UOW.Repository
{
    public class LeagueRepository : Repository<League>, ILeagueRepository
    {
        public LeagueRepository(UowDbContext dbContext, ILogger logger) : base(dbContext, logger)
        { }
    }
}
