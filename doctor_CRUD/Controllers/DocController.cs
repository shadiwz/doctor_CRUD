using doctor_CRUD.services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace doctor_CRUD.Controllers
{
    [ApiController]
    [Route("Doctor_crud")]
    public class DoctorController : ControllerBase
    {
        private IDocService _docService;

        public DoctorController(IDocService docService)
        {
            _docService = docService;
        }

        [HttpPost]
        public Doctor Post(Doctor doctor)
        {
            var doctorResult = _docService.Create(doctor);
            return doctorResult;
        }

        [HttpGet]
        public List<Doctor> Get()
        {
            return _docService.Get();
        }

        [HttpGet]
        [Route("{doctorId}")]
        public Doctor GetById(string doctorId)
        {
            return _docService.Get(doctorId);
        }

        [HttpDelete]
        [Route("{doctorId}")]
        public long DeletById(string doctorId)
        {
            return _docService.Remove(doctorId);
        }

        [HttpPut]
        [Route("{doctorId}")]
        public long UpdateById(string doctorId, [FromBody] Doctor doctor)
        {
            return _docService.Update(doctorId, doctor);
        }
    }
}
