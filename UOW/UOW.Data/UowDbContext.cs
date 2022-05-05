using Microsoft.EntityFrameworkCore;
using UOW.Data.Entities;

namespace UOW.Data
{
    public class UowDbContext : DbContext
    {
        public UowDbContext() : base() 
        {
        }

        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Player> Players { get; set; }
    }
}
