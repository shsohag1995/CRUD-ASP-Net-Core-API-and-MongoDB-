using CGC.Domain.Entity.Banking;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Application.IService.Banking
{
    public interface IExchangeCardService
    {
        Task<ExchangeCard> AddExchangeCard(ExchangeCard obj);
        Task UpdateExchangeCard(string id, ExchangeCard obj);
        Task DeleteExchangeCard(ExchangeCard obj);
        Task<IEnumerable<ExchangeCard>> GetExchangeCardList();
        ExchangeCard GetExchangeCardById(string id);
    }
}
