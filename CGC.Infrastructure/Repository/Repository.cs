using CGC.Domain.Entity;
using CGC.Domain.Entity.Common;
using CGC.Infrastructure.Data;
using CGC.Infrastructure.IRepository;
using Microsoft.Extensions.Options;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Infrastructure.Repository
{
    public class Repository<Tcollection> : IRepository<Tcollection> where Tcollection : BaseEntity
    {
        private readonly IMongoCollection<Tcollection> _collection;
        private readonly IMongoDatabase _database;

        public Repository(
       IOptions<MongoDBSettings> mongoDbSettings)
        {
            var mongoClient = new MongoClient(
                mongoDbSettings.Value.ConnectionString);

            _database = mongoClient.GetDatabase(
               mongoDbSettings.Value.DatabaseName);

            _collection = _database.GetCollection<Tcollection>(typeof(Tcollection).Name);
        }

        public Tcollection Insert(Tcollection entity)
        {
            _collection.InsertOne(entity);
            return entity;
        }
        public async Task InsertAsync(Tcollection entity)
        {
            await _collection.InsertOneAsync(entity);
        }


        public IEnumerable<Tcollection> InsertMany(IEnumerable<Tcollection> entities)
        {
            _collection.InsertMany(entities);
            return entities;
        }
        public async Task InsertManyAsync(IEnumerable<Tcollection> entities)
        {
            await _collection.InsertManyAsync(entities);

        }

        public Tcollection Update(string id, Tcollection entity)
        {
            _collection.ReplaceOne(x => x.Id == id, entity);
            return entity;
        }
        public async Task UpdateAsync(string id, Tcollection entity)
        {
            await _collection.ReplaceOneAsync(x => x.Id == id, entity);

        }
        public void UpdateMany(IEnumerable<Tcollection> entities)
        {
            foreach (var entity in entities)
            {
                _collection.ReplaceOne(x => x.Id == entity.Id, entity);
            }

        }
        public async Task UpdateManyAsync(IEnumerable<Tcollection> entities)
        {
            foreach (var entity in entities)
            {
                await _collection.ReplaceOneAsync(x => x.Id == entity.Id, entity);
            }
        }
        public void Delete(Tcollection entity)
        {
            _collection.DeleteOne(x => x.Id == entity.Id);
        }
        public async Task DeleteAsync(Tcollection entity)
        {
            await _collection.DeleteOneAsync(x => x.Id == entity.Id);
        }

        public void Delete(string id)
        {
            _collection.DeleteOne(x => x.Id == id);
        }
        public async Task DeleteAsync(string id)
        {
            await _collection.DeleteOneAsync(x => x.Id == id);
        }

        public void DeleteMany(IEnumerable<Tcollection> entities)
        {
            var entityIdsToDelete = entities.Select(entity => entity.Id);
            _collection.DeleteMany(x => entityIdsToDelete.Contains(x.Id));
        }
        public async Task DeleteManyAsync(IEnumerable<Tcollection> entities)
        {
            var entityIdsToDelete = entities.Select(entity => entity.Id);
            await _collection.DeleteManyAsync(x => entityIdsToDelete.Contains(x.Id));
        }
        public Tcollection Get(Tcollection entity)
        {
            Tcollection value = (Tcollection)_collection.Find(x => x == entity);
            return value;
        }
        /*
        public Task<IAsyncCursor<Tcollection>> GetById(string id)
        {
            var entity = _collection.FindAsync(x => x.Id == id);
            return entity;
        }
        */
       
        public Tcollection GetById(string id) =>  _collection.Find<Tcollection>(x => x.Id == id).FirstOrDefault();
        public List<Tcollection> GetAll() => _collection.Find(x => true).ToList();
       
        public async Task<IEnumerable<Tcollection>> GetAllAsync()
        {
            var entities = await _collection.Find(Builders<Tcollection>.Filter.Empty).ToListAsync();
            return entities;
        }
        // public Task<IAsyncCursor<Tcollection>> SearchFor(Expression<Func<User, bool>> predicate) => _collection.Find<Tcollection>(predicate).ToList();
        public  string WriteError(string message)
        {
            return message;
        }
    }
}
