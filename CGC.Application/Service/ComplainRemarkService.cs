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
    public class ComplainRemarkService: IComplainRemarkService
    {
        private readonly IRepository<ComplainRemark> _repository;
        public ComplainRemarkService(IRepository<ComplainRemark> repository)
        {
            _repository = repository;
        }
        public async Task<ComplainRemark> AddComplainRemark(ComplainRemark obj)
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
        public async Task UpdateComplainRemark(string id, ComplainRemark obj)
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
        public async Task DeleteComplainRemark(ComplainRemark obj)
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
        public async Task<IEnumerable<ComplainRemark>> GetComplainRemarkList()
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
        public  ComplainRemark GetComplainRemarkById(string id)
        {
            try
            {
                var obj =  _repository.GetById(id);
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
