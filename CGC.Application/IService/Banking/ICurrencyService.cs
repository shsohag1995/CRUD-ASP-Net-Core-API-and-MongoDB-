using CGC.Domain.Entity.Banking;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Application.IService.Banking
{
    public interface ICurrencyService
    {
        Task<Currency> AddCurrency(Currency obj);
        Task UpdateCurrency(string id, Currency obj);
        Task DeleteCurrency(Currency obj);
        Task<IEnumerable<Currency>> GetCurrencyList();
        Currency GetCurrencyById(string id);
    }
}
