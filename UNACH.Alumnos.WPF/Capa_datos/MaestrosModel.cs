using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace UNACH.Alumnos.WPF.Capa_datos
{
	public partial class MaestrosModel : DbContext
	{
		public MaestrosModel()
			: base("name=MaestrosModel")
		{
		}

		public virtual DbSet<Maestro> Maestros { get; set; }

		protected override void OnModelCreating(DbModelBuilder modelBuilder)
		{
			modelBuilder.Entity<Maestro>()
				.Property(e => e.Nombre)
				.IsUnicode(false);

			modelBuilder.Entity<Maestro>()
				.Property(e => e.Telefono)
				.IsUnicode(false);

			modelBuilder.Entity<Maestro>()
				.Property(e => e.Correo)
				.IsUnicode(false);
		}
	}
}
