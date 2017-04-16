using StateInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameInterface
{
	public interface IGame
	{
		string BuyGame();
		string InstallGame();
		string PlayGame();
		IState State { get; set; }
		
	}
}
