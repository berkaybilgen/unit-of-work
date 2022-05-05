using Microsoft.Extensions.Logging;
using UOW.Data;
using UOW.Data.Entities;

namespace UOW.Repository
{
    public class PlayerRepository : Repository<Player>, IPlayerRepository
    {
        public PlayerRepository(UowDbContext dbContext, ILogger logger) : base(dbContext, logger) 
        { }
    }
}
