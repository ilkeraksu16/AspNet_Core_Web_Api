using Microsoft.EntityFrameworkCore;
using NLayerApp.Core.Repositories;
using NLayerApp.Core.Services;
using NLayerApp.Core.UnitOfWorks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.Service.Services
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IGenericRepository<T> _productRepository;
        private readonly IUnitOfWork _unitOfWork;

        public Service(IGenericRepository<T> repository, IUnitOfWork unitOfWork)
        {
            _productRepository = repository;
            _unitOfWork = unitOfWork;
        }

        public async Task<T> AddAsync(T entity)
        {
            await _productRepository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            return entity;

        }

        public async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _productRepository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            return entities;
        }

        public async Task<bool> AnyAsync(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return await _productRepository.AnyAsync(expression);
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _productRepository.GetAll().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _productRepository.GetByIdAsync(id);
        }

        public async Task RemoveAsync(T entity)
        {
            _productRepository.Remove(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            _productRepository.RemoveRange(entities);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _productRepository.Update(entity);
            await _unitOfWork.CommitAsync();

        }

        public IQueryable<T> Where(System.Linq.Expressions.Expression<Func<T, bool>> expression)
        {
            return _productRepository.Where(expression);   
        }
    }
}
