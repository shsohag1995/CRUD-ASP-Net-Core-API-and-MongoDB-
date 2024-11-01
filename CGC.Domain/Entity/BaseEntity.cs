using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGC.Domain.Entity
{
    public abstract class BaseEntity
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonIgnoreIfDefault]
        public string Id { get; set; }
        public bool? status { get; set; } = true;
        public bool? IsSoftDelete { get; set; }=false;
        public DateTime? Created { get; set; }=DateTime.UtcNow;
        public DateTime? LastUpdated { get; set; }= DateTime.UtcNow;
    }
}
