using Command;
using CommandTerminal;
using Game;
using GameInterface;
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
		CommandTerminal.CommandTerminal CommandTerminal;
		Game.Game TheWitcher3;
		Game.Game DeusEx;

		public MainWindow()
		{
			InitializeComponent();

			CommandTerminal = new CommandTerminal.CommandTerminal();

			TheWitcher3 = new Game.Game();
			DeusEx = new Game.Game();

			CommandTerminal.SetCommand(0, new BuyCommand(TheWitcher3));
			CommandTerminal.SetCommand(1, new InstallCommand(TheWitcher3));
			CommandTerminal.SetCommand(2, new PlayCommand(TheWitcher3));
			CommandTerminal.SetCommand(3, new StopCommand(TheWitcher3));
			CommandTerminal.SetCommand(4, new UninstallCommand(TheWitcher3));

			CommandTerminal.SetCommand(5, new BuyCommand(DeusEx));
			CommandTerminal.SetCommand(6, new InstallCommand(DeusEx));
			CommandTerminal.SetCommand(7, new PlayCommand(DeusEx));
		}

		private void Button_Click_Install(object sender, RoutedEventArgs e)
		{
			string msg = CommandTerminal.ExecuteChosenCommand(1);
			MessageBox.Show(msg);
		}

		private void Button_Click_Play(object sender, RoutedEventArgs e)
		{
			string msg = CommandTerminal.ExecuteChosenCommand(2);
			MessageBox.Show(msg);
		}

		private void Button_Click_Buy(object sender, RoutedEventArgs e)
		{
			string msg = CommandTerminal.ExecuteChosenCommand(0);
			MessageBox.Show(msg);
			//Button bt = (Button)sender;
			//bt.Visibility = Visibility.Hidden;
			//Button wird vom Mediator disabled
		}

		private void Button_Click_Stop(object sender, RoutedEventArgs e)
		{
			string msg = CommandTerminal.ExecuteChosenCommand(3);
			MessageBox.Show(msg);
		}

		private void Button_Click_Uninstall(object sender, RoutedEventArgs e)
		{
			string msg = CommandTerminal.ExecuteChosenCommand(4);
			MessageBox.Show(msg);
		}



		private void Button_Click_Install_DE(object sender, RoutedEventArgs e)
		{
			string msg = CommandTerminal.ExecuteChosenCommand(6);
			MessageBox.Show(msg);
		}

		private void Button_Click_Play_DE(object sender, RoutedEventArgs e)
		{
			string msg = CommandTerminal.ExecuteChosenCommand(7);
			MessageBox.Show(msg);
		}

		private void Button_Click_Buy_DE(object sender, RoutedEventArgs e)
		{
			string msg = CommandTerminal.ExecuteChosenCommand(5);
			MessageBox.Show(msg);
		}
	}
}
