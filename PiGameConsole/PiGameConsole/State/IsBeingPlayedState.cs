using GameInterface;
using StateInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace State
{
	public class IsBeingPlayedState : IState
	{
		IGame Game;
		public IsBeingPlayedState(IGame Game)
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
			return "You are already playing!";
		}

		public string StopGame()
		{
			Game.State = new InstalledState(Game);
			return "You left the game!";
		}

		public string UninstallGame()
		{
			return "You cannot uninstall while playing";
		}
	}
}
