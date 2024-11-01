using CGC.Domain.Entity;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Infrastructure.IRepository
{
    public interface IRepository<Tcollection> where Tcollection : BaseEntity
    {
        Tcollection Insert(Tcollection entity);
        Task InsertAsync(Tcollection entity);
        IEnumerable<Tcollection> InsertMany(IEnumerable<Tcollection> entities);
        Task InsertManyAsync(IEnumerable<Tcollection> entities);
        Tcollection Update(string id, Tcollection entity);
        Task UpdateAsync(string id, Tcollection entity);
        void UpdateMany(IEnumerable<Tcollection> entities);
        Task UpdateManyAsync(IEnumerable<Tcollection> entities);
        void Delete(Tcollection entity);
        Task DeleteAsync(Tcollection entity);
        void Delete(string id);
        Task DeleteAsync(string id);
        void DeleteMany(IEnumerable<Tcollection> entities);
        Task DeleteManyAsync(IEnumerable<Tcollection> entities);
        Tcollection Get(Tcollection entity);
        Tcollection GetById(string id);
      //  Task<IAsyncCursor<Tcollection>> GetByIdAsync(string id);
        List<Tcollection> GetAll();
        // Task<IAsyncCursor<Tcollection>> GetAllAsync();
        Task<IEnumerable<Tcollection>> GetAllAsync();
        string WriteError(string message);
    }
}
