using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventSchedule.Core;
using EventSchedule.Infraestructure.Data.Context;

namespace EventSchedule.Infraestructure.Data
{
    public class RepositoryBase<TEntity> : IDisposable, IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly EventScheduleContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public RepositoryBase(EventScheduleContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }

        //public EventScheduleContext Db = new EventScheduleContext();

        public void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return DbSet.ToList();
        }

        public TEntity GetById(int id)
        {
            return DbSet.Find(id);
        }

        public void Remove(TEntity obj)
        {
            DbSet.Remove(obj);
        }

        public void Update(TEntity obj)
        {
            Db.Entry(obj).State = EntityState.Modified;
        }

        public void Dispose()
        {
            Db.Dispose();
        }        
    }
}