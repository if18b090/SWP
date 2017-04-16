using FirstGame;
using SecondGame;
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

namespace PiGameConsole
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		FirstGame.FirstGame TheWitcher3 = new FirstGame.FirstGame();
		SecondGame.SecondGame DeusEx = new SecondGame.SecondGame();

		private void Button_Click_Install(object sender, RoutedEventArgs e)
		{
			string msg = TheWitcher3.InstallGame();
			MessageBox.Show(msg);
		}

		private void Button_Click_Play(object sender, RoutedEventArgs e)
		{
			string msg = TheWitcher3.PlayGame();
			MessageBox.Show(msg);
		}

		private void Button_Click_Buy(object sender, RoutedEventArgs e)
		{
			string msg = TheWitcher3.BuyGame();
			MessageBox.Show(msg);
		}

		private void Button_Click_Install_DE(object sender, RoutedEventArgs e)
		{
			string msg = DeusEx.InstallGame();
			MessageBox.Show(msg);
		}

		private void Button_Click_Play_DE(object sender, RoutedEventArgs e)
		{
			string msg = DeusEx.PlayGame();
			MessageBox.Show(msg);
		}

		private void Button_Click_Buy_DE(object sender, RoutedEventArgs e)
		{
			string msg = DeusEx.BuyGame();
			MessageBox.Show(msg);
		}
	}
}
