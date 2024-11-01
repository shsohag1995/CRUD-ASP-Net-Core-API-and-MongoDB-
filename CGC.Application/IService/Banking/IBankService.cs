
using CGC.Domain.Entity.Banking;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Application.IService.Banking
{
    public interface IBankService
    {
        Task<Bank> AddBank(Bank obj);
        Task UpdateBank(string id, Bank obj);
        Task DeleteBank(Bank obj);
        Task<IEnumerable<Bank>> GetBankList();
        Bank GetBankById(string id);
    }
}
