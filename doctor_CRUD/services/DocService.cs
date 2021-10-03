using Microsoft.EntityFrameworkCore.Storage;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace doctor_CRUD.services
{
    public class DocService : IDocService
    {
        private readonly IMongoCollection<Doctor> _doctor;

        public DocService(IDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _doctor = database.GetCollection<Doctor>(settings.CollectionName);
        }

        public List<Doctor> Get()
        {
            return _doctor.Find(doctor => true).ToList();
        }

        public Doctor Get(string id)
        {
            return _doctor.Find<Doctor>(doctor => doctor.Id == id).FirstOrDefault();
        }

        public Doctor Create(Doctor doctor)
        {
            _doctor.InsertOne(doctor);
            return doctor;
        }

        public long Update(string id, Doctor doctoIn)
        {
            return _doctor.ReplaceOne(doctor => doctor.Id == id, doctoIn).ModifiedCount;
        }

        public long Remove(string id)
        {
            var doc = _doctor.DeleteOne(doc => doc.Id == id);
            return doc.DeletedCount;
        }
    }
}
