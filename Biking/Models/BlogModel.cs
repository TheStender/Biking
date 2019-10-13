using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace Biking.Models
{
    public class BlogModel
    {
        [BsonId]
        public Guid Id { get; set; }
        public string Mileage { get; set; }
        public string Date { get; set; }
    }
}
