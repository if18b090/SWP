using GameInterface;
using StateInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	public class BoughtState : IState
	{
		IGame Game;
		public BoughtState(IGame Game)
		{
			this.Game = Game;
		}

		public string BuyGame()
		{
			return "You already own this game!";
		}

		public string InstallGame()
		{
			Game.State = new InstalledState(Game);
			return "Game is being installed.";
		}

		public string PlayGame()
		{
			return "You need to install first!";
		}
	}
}
