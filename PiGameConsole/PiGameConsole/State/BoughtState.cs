﻿using GameInterface;
using StateInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

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
