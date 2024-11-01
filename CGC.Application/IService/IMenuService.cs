using CGC.Domain.Entity.Common;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Application.IService
{
    public interface IMenuService
    {
        Task<Menu> AddMenu(Menu obj);
        Task UpdateMenu(string id, Menu obj);
        Task DeleteMenu(Menu obj);
        Task<IEnumerable<Menu>> GetMenuList();
        Menu GetMenuById(string id);
    }
}
