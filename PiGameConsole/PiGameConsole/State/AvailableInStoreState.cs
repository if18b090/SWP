using GameInterface;
using StateInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	public class AvailableInStoreState : IState
	{
		IGame Game;
		public AvailableInStoreState(IGame game)
		{
			this.Game = game;
		}

		public string BuyGame()
		{
			Game.State = new BoughtState(Game);
			return "You bought this game!";
		}

		public string InstallGame()
		{
			return "You need to buy first!";
		}

		public string PlayGame()
		{
			return "You need to buy and install first!";
		}

		public string StopGame()
		{
			return "You are not playing!";
		}

		public string UninstallGame()
		{
			return "Game is not installed!";
		}
	}
}
