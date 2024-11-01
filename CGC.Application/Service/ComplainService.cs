using CGC.Application.IService;
using CGC.Domain.Entity.Common;
using CGC.Infrastructure.IRepository;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Application.Service
{
    public class ComplainService: IComplainService
    {
        private readonly IRepository<Complain> _repository;
        public ComplainService(IRepository<Complain> repository)
        {
            _repository = repository;
        }
        public async Task<Complain> AddComplain(Complain obj)
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
        public async Task UpdateComplain(string id, Complain obj)
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
        public async Task DeleteComplain(Complain obj)
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
        public async Task<IEnumerable<Complain>> GetComplainList()
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
        public Complain GetComplainById(string id)
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
