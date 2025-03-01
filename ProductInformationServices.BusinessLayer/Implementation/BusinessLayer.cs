using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductInformationServices.BusinessLayer.Interface;
using ProductInformationServices.Repository.Interface;

namespace ProductInformationServices.BusinessLayer.Implementation
{
    public class BusinessLayer<T> : IBusinessLayer<T> where T : class
    {
        private readonly IRepository<T> _repository;

        public BusinessLayer(IRepository<T> repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<T> GetByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }
        public async Task AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
        }
        public async Task UpdateAsync(T entity)
        {
            await _repository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(int id)
        {
           await _repository.DeleteAsync(id);
        }
    }
}
