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
    public class BankService: IBankService
    {
        private readonly IRepository<Bank> _repository;
        public BankService(IRepository<Bank> repository)
        {
            _repository = repository;
        }
        public async Task<Bank> AddBank(Bank obj)
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
        public async Task UpdateBank(string id, Bank obj)
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
        public async Task DeleteBank(Bank obj)
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
        public async Task<IEnumerable<Bank>> GetBankList()
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
        public Bank GetBankById(string id)
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
