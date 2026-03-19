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
		public List<Alumno> ObtenerAlumnos()
		{
			using (AlumnosModel context = new AlumnosModel())
			{
				var listaAlumnos = context.Alumnos.ToList();
				return listaAlumnos;
			}
		}
		/// <summary>
		/// Consulta de alumnos filtrados
		/// </summary>
		/// <param name="nombre">campo string</param>
		/// <returns>Lista de alumnos</returns>
		public List<Alumno> ObtenerAlumnosPorNombre(string nombre)
		{
			using (var context = new AlumnosModel())
			{
				return (from a in context.Alumnos
						where a.Nombre.Contains(nombre)
						select a)
					   .ToList();
			}
		}
		public bool InsertarAlumno(Alumno alumno)
		{
			try
			{
				using (var context = new AlumnosModel())
				{
					context.Alumnos.Add(alumno);
					context.SaveChanges();
					return true;
				}
			}
			catch (Exception ex)
			{
				return false;
			}
		}
		public bool EliminarAlumno(int id)
		{
			try
			{
				using (var context = new AlumnosModel())
				{
					var alumno = (from a in context.Alumnos
								  where a.id == id
								  select a).FirstOrDefault();
					if (alumno != null)
					{
						context.Alumnos.Remove(alumno);
						context.SaveChanges();
						return true;
					}
					else
					{
						return false;
					}
				}
			}
			catch (Exception ex)
			{
				return false;
			}
		}
		public bool EditarAlumno(Alumno alumno)
		{
			try
			{
				using (var context = new AlumnosModel())
				{
					var _alumno = (from a in context.Alumnos
								  where a.id == alumno.id
								  select a).FirstOrDefault();
					if (_alumno != null)
					{
						_alumno.Nombre = alumno.Nombre;
						_alumno.Telefono = alumno.Telefono;
						context.SaveChanges();
						return true;
					}
					else
					{
						return false;
					}
				}
			}
			catch (Exception ex)
			{
				return false;
			}
		}
	}
}
