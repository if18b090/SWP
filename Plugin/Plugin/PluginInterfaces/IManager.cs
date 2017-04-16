using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginInterfaces
{
    public interface IManager
    {
        List<IPlugin> ManagerList { get; }
        void Add(object obj);
        void Remove(object obj);
    }
}
