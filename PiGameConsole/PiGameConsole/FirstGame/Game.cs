using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameInterface;
using StateInterface;
using State;

namespace Game
{
	public class Game : IGame
	{
		IState currentState;
		public string Name { get; set; }

		public Game()
		{
			currentState = new AvailableInStoreState(this);
		}

		public Game(string name)
		{
			Name = name;
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

		public string StopGame()
		{
			return State.StopGame();
		}

		public string UninstallGame()
		{
			return State.UninstallGame();
		}
	}
}
