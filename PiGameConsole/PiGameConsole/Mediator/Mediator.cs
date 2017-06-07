using GameInterface;
using State;
using StateInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Mediator
{
	public class Mediator
	{
		public void refreshButtons(List<Button> buttons, IGame game)
		{
			IState state = game.State;

				if (state.GetType().Equals(new AvailableInStoreState(game).GetType()))
				{
					buttons[0].Visibility = Visibility.Visible;
					buttons[1].Visibility = Visibility.Collapsed;
					buttons[2].Visibility = Visibility.Collapsed;
					buttons[3].Visibility = Visibility.Collapsed;
					buttons[4].Visibility = Visibility.Collapsed;
				}

				else if (state.GetType().Equals(new BoughtState(game).GetType()))
				{
					buttons[0].Visibility = Visibility.Collapsed;
					buttons[1].Visibility = Visibility.Visible;
					buttons[2].Visibility = Visibility.Collapsed;
					buttons[3].Visibility = Visibility.Collapsed;
					buttons[4].Visibility = Visibility.Collapsed;
				}

				else if (state.GetType().Equals(new InstalledState(game).GetType()))
				{
					buttons[0].Visibility = Visibility.Collapsed;
					buttons[1].Visibility = Visibility.Collapsed;
					buttons[2].Visibility = Visibility.Visible;
					buttons[3].Visibility = Visibility.Collapsed;
					buttons[4].Visibility = Visibility.Visible;
				}

				else if (state.GetType().Equals(new IsBeingPlayedState(game).GetType()))
				{
					buttons[0].Visibility = Visibility.Collapsed;
					buttons[1].Visibility = Visibility.Collapsed;
					buttons[2].Visibility = Visibility.Collapsed;
					buttons[3].Visibility = Visibility.Visible;
					buttons[4].Visibility = Visibility.Collapsed;
				}
			}
	}
}
