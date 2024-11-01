using CGC.Domain.Entity.Banking;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Application.IService.Banking
{
    public interface ICurrencyToCGCService
    {
        Task<CurrencyToCGC> AddCurrencyToCGC(CurrencyToCGC obj);
        Task UpdateCurrencyToCGC(string id, CurrencyToCGC obj);
        Task DeleteCurrencyToCGC(CurrencyToCGC obj);
        Task<IEnumerable<CurrencyToCGC>> GetCurrencyToCGCList();
        CurrencyToCGC GetCurrencyToCGCById(string id);
    }
}
