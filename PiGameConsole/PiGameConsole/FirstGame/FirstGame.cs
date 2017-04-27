using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInterface;
using StateInterface;
using State;

namespace FirstGame
{
	public class FirstGame : IGame
	{
		IState currentState;

		public FirstGame()
		{
			currentState = new AvailableInStoreState(this);
		}

		public IState State
		{
			get
			{
				return currentState;
			}

			set
			{
				currentState = value;
			}
		}

		public string BuyGame()
		{
			return State.BuyGame();
		}

		public string InstallGame()
		{
			return State.InstallGame();
		}

		public string PlayGame()
		{
			return State.PlayGame();
		}
	}
}
