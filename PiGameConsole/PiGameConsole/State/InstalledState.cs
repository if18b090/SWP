using GameInterface;
using StateInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	public class InstalledState : IState
	{
		IGame Game;
		public InstalledState(IGame Game)
		{
			this.Game = Game;
		}

		public string BuyGame()
		{
			return "You already own this game!";
		}

		public string InstallGame()
		{
			return "Already installed!";
		}

		public string PlayGame()
		{
			Game.State = new IsBeingPlayedState(Game);
			return "Starting game!";
		}

		public string StopGame()
		{
			return "You are not playing!";
		}

		public string UninstallGame()
		{
			Game.State = new BoughtState(Game);
			return "Uninstall succesful!";
		}
	}
}
