using System.Collections.Generic;
using System.Threading.Tasks;

namespace UOW.Repository
{
    public interface IRepository<T> where T : class
    {
        Task Add(T entity);
        void Update(T entity);
        Task<List<T>> Get();
    }
}
