using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StateInterface
{
	public interface IState
	{
		string BuyGame();
		string InstallGame();
		string PlayGame();
	}
}
