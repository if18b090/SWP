using GameInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class StopCommand : ICommand
	{
		IGame Game;

		public StopCommand(IGame game)
		{
			Game = game;
		}

		public string Execute()
		{
			return Game.StopGame();
		}
	}
}
