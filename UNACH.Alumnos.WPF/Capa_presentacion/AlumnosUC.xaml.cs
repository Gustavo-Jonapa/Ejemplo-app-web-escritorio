using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace UNACH.Alumnos.WPF.Capa_presentacion
{
	/// <summary>
	/// Lógica de interacción para AlumnosUC.xaml
	/// </summary>
	public partial class AlumnosUC : UserControl
	{
		public AlumnosUC()
		{
			InitializeComponent();
		}

		private void UserControl_Loaded(object sender, RoutedEventArgs e)
		{
			Capa_logica.AlumnosCore alu = new Capa_logica.AlumnosCore();
			AlumnosDG.ItemsSource = alu.ObtenerAlumnos();
		}
    }
}
