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
	/// Lógica de interacción para MaestrosUC.xaml
	/// </summary>
	public partial class MaestrosUC : UserControl
	{
		public MaestrosUC()
		{
			InitializeComponent();
		}
		private void UserControl_Loaded(object sender, RoutedEventArgs e)
		{
			Capa_logica.MaestrosCore prof = new Capa_logica.MaestrosCore();
			MaestrosDG.ItemsSource = prof.ObtenerMaestros();
		}
	}
}
