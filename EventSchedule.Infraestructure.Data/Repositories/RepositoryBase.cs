using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventSchedule.Core.Interfaces.Repositories;
using EventSchedule.Infraestructure.Data.Context;

namespace EventSchedule.Infraestructure.Data.Repositories
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected EventScheduleContext Db = new EventScheduleContext();

        public async Task Add(TEntity obj)
        {
            Db.Set<TEntity>().Add(obj);
            await Db.SaveChangesAsync();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Db.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return Db.Set<TEntity>().Find(id);
        }

        public async Task Remove(TEntity obj)
        {
            Db.Set<TEntity>().Remove(obj);
            await Db.SaveChangesAsync();
        }

        public async Task Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
            await Db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Db.Dispose();
        }
    }
}