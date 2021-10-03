using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;

namespace doctor_CRUD
{
    public class Doctor
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        public string Name { get; set; }

        public string CPF { get; set; }

        public string Email { get; set; }

        public List<AderessDescription> Adress { get; set; }

        public List<PhoneDescription> PhoneNumber { get; set; }

        public class AderessDescription
        {
            public string Adress { get; set; }
            public string Description { get; set; }
        }

        public class PhoneDescription
        {
            public string NickName { get; set; }
            public string Phone { get; set; }
        }
    }
}
