using awsdoctoresapi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace awsdoctoresapi.Data
{
    public class DoctoresContext:DbContext
    {
        public DoctoresContext(DbContextOptions<DoctoresContext> options) : base(options) { }

        public DbSet<Doctores> Doctores { get; set; }
    }
}
