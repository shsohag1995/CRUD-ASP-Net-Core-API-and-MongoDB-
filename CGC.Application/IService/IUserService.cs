using CGC.Domain.Entity.Common;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Application.IService
{
    public interface IUserService
    {
        Task<User> AddUser(User user);
        Task UpdateUser(string id, User user);
        Task DeleteUser(User user);
        Task<IEnumerable<User>> GetUserList();
        User GetUserById(string id);
       


    }
}
