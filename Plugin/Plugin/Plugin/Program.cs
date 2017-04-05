using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginInterfaces;
using MyFirstPlugin;

namespace CRMSoft
{
    class Program
    {
        static void Main(string[] args)
        {
            PluginManager Manager = new PluginManager();
            List<IPlugin> PluginsList = Manager.ManagerList;

            foreach (IPlugin p in PluginsList)
            {

            }

            Customer Fred = new Customer();

        }
    }
}
