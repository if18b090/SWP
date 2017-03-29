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
        public List<IPlugin> ManagerList
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Add(object obj)
        {
            throw new NotImplementedException();
        }

        public void Remove(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
