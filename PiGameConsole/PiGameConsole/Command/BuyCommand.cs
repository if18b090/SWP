using GameInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class BuyCommand : ICommand
	{
		IGame Game;

		public BuyCommand(IGame game)
		{
			Game = game;
		}

		public string Execute()
		{
			return Game.BuyGame();
		}
	}
}
