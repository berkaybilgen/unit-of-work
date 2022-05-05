using Microsoft.Extensions.Logging;
using UOW.Data;
using UOW.Data.Entities;

namespace UOW.Repository
{
    public class TeamRepository : Repository<Team>, ITeamRepository
    {
        public TeamRepository(UowDbContext dbContext, ILogger logger) : base(dbContext, logger) 
        { }
    }
}
