using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MongoDB_Demo
{
    public class Book
    {
        [BsonId]
        public ObjectId Id { get; set; }

        public string Title { get; set; }

        public int YearPublished { get; set; }
    }
}
