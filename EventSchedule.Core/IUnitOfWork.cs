using System;
using System.Threading.Tasks;

namespace EventSchedule.Core
{
    public interface IUnitOfWork : IDisposable
    {       
        Task SaveChangesAsync();      
    }   
}