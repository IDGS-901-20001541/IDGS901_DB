using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;

namespace IDGS901_DB1.Models
{
    public class AlumnosDBContext:DbContext
    {

        private static string connection = "DefaultConnection";
        public AlumnosDBContext() : base(connection) { }
        public DbSet<Alumnos> Alumnos { get; set; } //crear la tabla 


    }
}