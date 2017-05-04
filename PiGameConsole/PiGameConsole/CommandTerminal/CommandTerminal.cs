using Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandTerminal
{
	public class CommandTerminal
	{
		ICommand[] commands;

		public CommandTerminal()
		{
			commands = new ICommand[10];
		}

		public void SetCommand(int position, ICommand command)
		{
			commands[position] = command;
		}

		public string ExecuteChosenCommand(int position)
		{
			return commands[position].Execute();
		}
	}
}
