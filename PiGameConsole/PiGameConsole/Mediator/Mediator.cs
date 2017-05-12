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
		public void disableTheButton(List<Button> buttons, IGame game)
		{
			IState state = game.State;
			if (state.Equals(new BoughtState(game)))
			{
				buttons[0].Visibility = Visibility.Hidden;
				buttons[1].Visibility = Visibility.Hidden;
				buttons[2].Visibility = Visibility.Hidden;
			}

			}
		}
	}
