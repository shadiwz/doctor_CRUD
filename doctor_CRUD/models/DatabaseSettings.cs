using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;

namespace doctor_CRUD
{
    public class DatabaseSettings: IDatabaseSettings
    {
        public string CollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IDatabaseSettings
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}
