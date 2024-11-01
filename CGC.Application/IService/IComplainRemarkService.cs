
using CGC.Domain.Entity.Common;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Application.IService
{
    public interface IComplainRemarkService
    {
        Task<ComplainRemark> AddComplainRemark(ComplainRemark obj);
        Task UpdateComplainRemark(string id, ComplainRemark obj);
        Task DeleteComplainRemark(ComplainRemark obj);
        Task<IEnumerable<ComplainRemark>> GetComplainRemarkList();
        ComplainRemark GetComplainRemarkById(string id);
    }
}
