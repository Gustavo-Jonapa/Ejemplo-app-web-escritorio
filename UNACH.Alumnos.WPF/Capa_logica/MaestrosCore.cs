using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UNACH.Alumnos.WPF.Capa_datos;

namespace UNACH.Alumnos.WPF.Capa_logica
{
	internal class MaestrosCore
	{
		public List<Maestro> ObtenerMaestros()
		{
			using (MaestrosModel context = new MaestrosModel())
			{
				var listaMaestros = context.Maestros.ToList();
				return listaMaestros;
			}
		}
	}
}
