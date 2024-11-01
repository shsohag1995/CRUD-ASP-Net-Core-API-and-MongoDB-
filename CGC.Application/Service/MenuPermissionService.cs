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
    public class MenuPermissionService: IMenuPermissionService
    {
        private readonly IRepository<MenuPermission> _repository;
        public MenuPermissionService(IRepository<MenuPermission> repository) {
        _repository = repository;
        }
        public async Task<MenuPermission> AddMenuPermission(MenuPermission obj)
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
        public async Task UpdateMenuPermission(string id, MenuPermission obj)
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
        public async Task DeleteMenuPermission(MenuPermission obj)
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
        public async Task<IEnumerable<MenuPermission>> GetMenuPermissionList()
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
        public MenuPermission GetMenuPermissionById(string id)
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
