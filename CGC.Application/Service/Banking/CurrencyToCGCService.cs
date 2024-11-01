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
    public class CurrencyToCGCService: ICurrencyToCGCService
    {
        private readonly IRepository<CurrencyToCGC> _repository;
        public CurrencyToCGCService(IRepository<CurrencyToCGC> repository)
        {
            _repository = repository;
        }
        public async Task<CurrencyToCGC> AddCurrencyToCGC(CurrencyToCGC obj)
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
        public async Task UpdateCurrencyToCGC(string id, CurrencyToCGC obj)
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
        public async Task DeleteCurrencyToCGC(CurrencyToCGC obj)
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
        public async Task<IEnumerable<CurrencyToCGC>> GetCurrencyToCGCList()
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
        public CurrencyToCGC GetCurrencyToCGCById(string id)
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
