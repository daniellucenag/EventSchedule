
using EventSchedule.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EventSchedule.Core.Interfaces.Services;

namespace EventSchedule.Application
{
    public class AppServiceBase<TEntity> : IDisposable, IAppServiceBase<TEntity> where TEntity : class
    {
        private readonly IServiceBase<TEntity> _serviceBase;
        public AppServiceBase(IServiceBase<TEntity> serviceBase)
        {
            _serviceBase = serviceBase;
        }

        public async Task Add(TEntity obj)
        {
            await _serviceBase.Add(obj);
        }

        public TEntity GetById(int id)
        {
            return _serviceBase.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _serviceBase.GetAll();
        }

        public async Task Update(TEntity obj)
        {
            await _serviceBase.Update(obj);
        }

        public async Task Remove(TEntity obj)
        {
            await _serviceBase.Remove(obj);
        }

        public void Dispose()
        {
            _serviceBase.Dispose();
        }
    }
}