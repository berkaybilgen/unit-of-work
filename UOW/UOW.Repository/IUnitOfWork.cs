using System.Threading.Tasks;

namespace UOW.Repository
{
    public interface IUnitOfWork
    {
        Task CommityAsync();
    }
}
