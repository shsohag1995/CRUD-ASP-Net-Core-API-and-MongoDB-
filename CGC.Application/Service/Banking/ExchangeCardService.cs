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
    public class ExchangeCardService: IExchangeCardService
    {
        private readonly IRepository<ExchangeCard> _repository;
        public ExchangeCardService(IRepository<ExchangeCard> repository)
        {
            _repository = repository;
        }
        public async Task<ExchangeCard> AddExchangeCard(ExchangeCard obj)
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
        public async Task UpdateExchangeCard(string id, ExchangeCard obj)
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
        public async Task DeleteExchangeCard(ExchangeCard obj)
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
        public async Task<IEnumerable<ExchangeCard>> GetExchangeCardList()
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
        public ExchangeCard GetExchangeCardById(string id)
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
