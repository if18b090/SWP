using Command;
using CommandTerminal;
using Game;
using GameInterface;
using StateInterface;
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
		Game.Game CrazyCatLadyAdventure7;
		Mediator.Mediator Mediator;
		List<Button> Buttons;

		IGame SelectedGame;

		public MainWindow()
		{
			CommandTerminal = new CommandTerminal.CommandTerminal();
			TheWitcher3 = new Game.Game("The Witcher 3");
			DeusEx = new Game.Game("Deus Ex");
			CrazyCatLadyAdventure7 = new Game.Game("Crazy Cat Lady Adventure 7");
			Mediator = new Mediator.Mediator();
			SelectedGame = TheWitcher3;

			InitializeComponent();

			Buttons = new List<Button>() { BuyButton, InstallButton, PlayButton, StopButton, UninstallButton };
		}

		private void OnListItemSelect(object sender, SelectionChangedEventArgs args)
		{
			ListBox lb = (ListBox)sender;
			string item = lb.SelectedItem.ToString();

			switch (item)
			{
				case "The Witcher 3":
					SelectedGame = TheWitcher3;
					break;
				case "Deus Ex":
					SelectedGame = DeusEx;
					break;
				case "Crazy Cat Lady Adventure 7":
					SelectedGame = CrazyCatLadyAdventure7;
					break;
				default:
					SelectedGame = TheWitcher3;
					break;
			}

			CommandTerminal.SetCommand(0, new BuyCommand(SelectedGame));
			CommandTerminal.SetCommand(1, new InstallCommand(SelectedGame));
			CommandTerminal.SetCommand(2, new PlayCommand(SelectedGame));
			CommandTerminal.SetCommand(3, new StopCommand(SelectedGame));
			CommandTerminal.SetCommand(4, new UninstallCommand(SelectedGame));
			Mediator.manageButtons(Buttons, SelectedGame);
		}

		private void ListBoxItem_Initialized(object sender, EventArgs e)
		{
			ListBox lb = sender as ListBox;
			lb.Items.Add(TheWitcher3.Name);
			lb.Items.Add(DeusEx.Name);
			lb.Items.Add(CrazyCatLadyAdventure7.Name);
			SelectedGame = TheWitcher3;
		}

		private void Button_Click_Buy(object sender, RoutedEventArgs e)
		{
			string msg = CommandTerminal.ExecuteChosenCommand(0);
			Mediator.manageButtons(Buttons, SelectedGame);
			MessageBox.Show(msg);
		}

		private void Button_Click_Install(object sender, RoutedEventArgs e)
		{
			string msg = CommandTerminal.ExecuteChosenCommand(1);
			Mediator.manageButtons(Buttons, SelectedGame);
			MessageBox.Show(msg);
		}

		private void Button_Click_Play(object sender, RoutedEventArgs e)
		{
			string msg = CommandTerminal.ExecuteChosenCommand(2);
			Mediator.manageButtons(Buttons, SelectedGame);
			MessageBox.Show(msg);
		}

		private void Button_Click_Stop(object sender, RoutedEventArgs e)
		{
			string msg = CommandTerminal.ExecuteChosenCommand(3);
			Mediator.manageButtons(Buttons, SelectedGame);
			MessageBox.Show(msg);
		}

		private void Button_Click_Uninstall(object sender, RoutedEventArgs e)
		{
			string msg = CommandTerminal.ExecuteChosenCommand(4);
			Mediator.manageButtons(Buttons, SelectedGame);
			MessageBox.Show(msg);
		}
	}
}
