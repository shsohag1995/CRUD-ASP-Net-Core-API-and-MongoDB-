using CGC.Domain.Entity.Common;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Application.IService
{
    public interface IMenuPermissionService
    {
        Task<MenuPermission> AddMenuPermission(MenuPermission obj);
        Task UpdateMenuPermission(string id, MenuPermission obj);
        Task DeleteMenuPermission(MenuPermission obj);
        Task<IEnumerable<MenuPermission>> GetMenuPermissionList();
        MenuPermission GetMenuPermissionById(string id);
    }
}
