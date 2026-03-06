using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace UNACH.Alumnos.Sitio100019241.Models
{
    public partial class BdEscuelaModel : DbContext
    {
        public BdEscuelaModel()
            : base("name=EscuelaModel")
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>()
                .Property(e => e.Nombre)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Telefono)
                .IsUnicode(false);

            modelBuilder.Entity<Alumno>()
                .Property(e => e.Correo)
                .IsUnicode(false);
        }
    }
}
