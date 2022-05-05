using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UOW.Data;
using UOW.Data.Entities;

namespace UOW.Repository
{
    public class Repository<T> : IRepository<T> where T : BaseEntity
    {
        protected UowDbContext _dbContext;
        internal DbSet<T> _dbSet;
        protected readonly ILogger _logger;

        public Repository(UowDbContext dbContext, ILogger logger)
        {
            _dbContext = dbContext;
            _logger = logger;
            _dbSet = dbContext.Set<T>();
        }

        public async Task Add(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task<List<T>> Get()
        {
            return await _dbSet.Where(x => x.IsActive).ToListAsync();
        }

        public void Update(T entity)
        {
            _dbSet.Update(entity);
        }
    }
}
