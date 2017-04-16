using GameInterface;
using State;
using StateInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondGame
{
	public class SecondGame : IGame
		{
			IState currentState;

			public SecondGame()
			{
				currentState = new AvailableInStoreState(this);
				//State = currentState;
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

