using CGC.Domain.Entity.Common;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Application.IService
{
    public interface IComplainService
    {
        Task<Complain> AddComplain(Complain obj);
        Task UpdateComplain(string id, Complain obj);
        Task DeleteComplain(Complain obj);
        Task<IEnumerable<Complain>> GetComplainList();
        Complain GetComplainById(string id);
    }
}
