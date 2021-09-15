using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ACResume.DAL.Models
{
    public class MyResume
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public virtual string Id { get; set; }
        [BsonElement("Name")]
        [MaxLength(255)]
        public virtual string Name { get; set; }
        [MaxLength(255)]
        public virtual string Email { get; set; }
        [MaxLength(12)]
        public virtual string Phone { get; set; }
        [MaxLength(255)]
        public virtual string Location { get; set; }
        public virtual List<string> Skills { get; set; }
        public virtual string Experience { get; set; }
    }
}
