using awsdoctoresapi.Models;
using awsdoctoresapi.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace awsdoctoresapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {
       private RepositoryDoctores repo;

        public DoctorController(RepositoryDoctores repo)
        {
            this.repo = repo;
        }

        [HttpGet]

        public ActionResult<List<Doctores>> GetDoctores()
        {
            return this.repo.GetDoctor();
        }

        [HttpGet("{id}")]

        public ActionResult<Doctores>GetDoctor(string id)
        {
            return this.repo.GetDoctorId(id);
        }

        [HttpPost]

        public ActionResult InsertarDoctores(Doctores doctores)
        {
            this.repo.InsertarDoctor(doctores.IdHospital, doctores.IdDoctor, doctores.Apellido, doctores.Especialidad, doctores.Salario, doctores.Imagen);
            return Ok();
        }

        [HttpPut]

        public ActionResult UpdateDoctores(Doctores doctores)
        {
            this.repo.EditarDoctor(doctores.IdHospital, doctores.IdDoctor, doctores.Apellido, doctores.Especialidad, doctores.Salario, doctores.Imagen);
            return Ok();
        }

        [HttpDelete("{id}")]

        public void DeleteDoctores(string id)
        {
            this.repo.DeleteDoctor(id);
        }
    }
}
