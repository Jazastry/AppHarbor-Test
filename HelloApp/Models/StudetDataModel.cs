using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloApp.Models
{
    public class StudentDataModel
    {
        [BsonId]
        public ObjectId Id { get; set;}

        public string Name { get; set; }

        public string BirthDay { get; set; }
    }
}