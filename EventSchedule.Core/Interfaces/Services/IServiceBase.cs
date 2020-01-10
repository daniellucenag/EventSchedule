using System.Collections.Generic;
using System.Threading.Tasks;

namespace EventSchedule.Core.Interfaces.Services
{
    public interface IServiceBase<TEntity> where TEntity : class
    {
        Task Add(TEntity obj);
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        Task Update(TEntity obj);
        Task Remove(TEntity obj);
        void Dispose();
    }
}