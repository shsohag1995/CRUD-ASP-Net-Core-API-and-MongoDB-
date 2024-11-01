using CGC.Domain.Entity.Common;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Application.IService
{
    public interface IRoleService
    {
        Task<Role> AddRole(Role obj);
        Task UpdateRole(string id, Role obj);
        Task DeleteRole(Role obj);
        Task<IEnumerable<Role>> GetRoleList();
        Role GetRoleById(string id);
    }
}
