using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EventSchedule.Core.Interfaces.Repositories;
using EventSchedule.Core.Interfaces.Services;
using EventSchedule.Core.Interfaces.UnitOfWork;

namespace EventSchedule.Core.Services
{
    public class ServiceBase<TEntity> : IDisposable, IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        private readonly IUnitOfWork _unitOfWork;
        public ServiceBase(IRepositoryBase<TEntity> repository, IUnitOfWork unitOfWork)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
            _unitOfWork.SaveChangesAsync();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
            _unitOfWork.SaveChangesAsync();
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }
    }
}