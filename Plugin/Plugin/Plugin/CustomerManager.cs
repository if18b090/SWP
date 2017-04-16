using PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plugin
{
    class CustomerManager : IManager
    {
        public List<IPlugin> ManagerList { get; }

        public void Add(object obj)
        {
			ManagerList.Add((IPlugin)obj);

		}

        public void Remove(object obj)
        {
			ManagerList.Remove((IPlugin)obj);
        }
    }
}
