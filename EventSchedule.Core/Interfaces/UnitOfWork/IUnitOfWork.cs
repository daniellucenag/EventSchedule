using EventSchedule.Core.Interfaces.Repositories;
using System;
using System.Threading.Tasks;

namespace EventSchedule.Core.Interfaces.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {       
        Task SaveChangesAsync();      
    }
   
}