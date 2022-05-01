using awsdoctoresapi.Data;
using awsdoctoresapi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace awsdoctoresapi.Repositories
{
    public class RepositoryDoctores
    {

        private DoctoresContext context;

        public RepositoryDoctores(DoctoresContext context)
        {
            this.context = context;
        }

        public List<Doctores> GetDoctor()
        {
           return this.context.Doctores.ToList();
        }

        public Doctores GetDoctorId(string id)
        {
            return this.context.Doctores.SingleOrDefault(z => z.IdDoctor == id);
        }

        public void DeleteDoctor(string id)
        {
            Doctores doc = this.GetDoctorId(id);
            this.context.Doctores.Remove(doc);
            this.context.SaveChanges();
        }

        public void InsertarDoctor(string idhos, string iddoc, string apellido, string especialidad, int salario, string imagen)
        {
            Doctores doc = new Doctores();
            doc.IdHospital = idhos;
            doc.IdDoctor = iddoc;
            doc.Apellido = apellido;
            doc.Especialidad = especialidad;
            doc.Salario = salario;
            doc.Imagen = imagen;
            this.context.Doctores.Add(doc);
            this.context.SaveChanges();
        }

        public void EditarDoctor(string idhos, string iddoc, string apellido, string especialidad, int salario, string imagen)
        {
            Doctores doc = this.GetDoctorId(iddoc);
            doc.IdHospital = idhos;
            doc.Apellido = apellido;
            doc.Especialidad = especialidad;
            doc.Salario = salario;
            doc.Imagen = imagen;
            this.context.SaveChanges();
        }
    }
}
