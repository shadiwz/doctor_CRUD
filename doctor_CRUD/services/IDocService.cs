using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace doctor_CRUD.services
{
    public interface IDocService
    {
        List<Doctor> Get();
        Doctor Get(string id);
        Doctor Create(Doctor doctor);
        long Update(string id, Doctor doctor);
        long Remove(string id);
    }
}
