using GameInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class PlayCommand : ICommand
	{
		IGame Game;

		public PlayCommand(IGame game)
		{
			Game = game;
		}

		public string Execute()
		{
			return Game.PlayGame();
		}
	}
}
