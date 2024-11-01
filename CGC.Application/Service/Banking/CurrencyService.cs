using CGC.Application.IService.Banking;
using CGC.Domain.Entity.Banking;
using CGC.Infrastructure.IRepository;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Application.Service.Banking
{
    public class CurrencyService: ICurrencyService
    {
        private readonly IRepository<Currency> _repository;
        public CurrencyService(IRepository<Currency> repository)
        {
            _repository = repository;
        }
        public async Task<Currency> AddCurrency(Currency obj)
        {
            try
            {
                await _repository.InsertAsync(obj);
                return obj;
            }
            catch (Exception ex)
            {
                _repository.WriteError(ex.Message);
                throw;
            }
        }
        public async Task UpdateCurrency(string id, Currency obj)
        {
            try
            {
                await _repository.UpdateAsync(id, obj);
            }
            catch (Exception ex)
            {
                _repository.WriteError(ex.Message);
                throw;
            }
        }
        public async Task DeleteCurrency(Currency obj)
        {
            try
            {
                await _repository.DeleteAsync(obj);
            }
            catch (Exception ex)
            {
                _repository.WriteError(ex.Message);
                throw;
            }

        }
        public async Task<IEnumerable<Currency>> GetCurrencyList()
        {
            try
            {
                var obj = await _repository.GetAllAsync();
                return obj;
            }
            catch (Exception ex)
            {
                _repository.WriteError(ex.Message);
                throw;
            }
        }
        public Currency GetCurrencyById(string id)
        {
            try
            {
                var obj = _repository.GetById(id);
                return obj;

            }
            catch (Exception ex)
            {
                _repository.WriteError(ex.Message);
                throw;
            }
        }
    }
}
