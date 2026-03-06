using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNACH.Alumnos.WPF.Capa_datos;

namespace UNACH.Alumnos.WPF.Capa_logica
{
	public class AlumnosCore
	{
		/// <summary>
		/// Método para obtener alumnos
		/// </summary>
		/// <returns>lista de alumnos</returns>
		public List<Alumno>ObtenerAlumnos()
		{
			using (AlumnosModel context =new AlumnosModel())
			{
				var listaAlumnos = context.Alumnos.ToList();
				return listaAlumnos;
			}
		}
	}
}
