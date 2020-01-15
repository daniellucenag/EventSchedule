using EventSchedule.Core.Interfaces.UnitOfWork;
using EventSchedule.Infraestructure.Data.Context;
using System;
using System.Threading.Tasks;

namespace EventSchedule.Infraestructure.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        protected readonly EventScheduleContext Db;

        public UnitOfWork(EventScheduleContext eventScheduleContext)
        {
            Db = eventScheduleContext;
        }

        public async Task SaveChangesAsync()
        {
            await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}