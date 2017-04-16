using PluginInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstPlugin
{
    class CustomerSatisfaction : IPlugin
    {
		public int satisfaction;
		public bool wouldRecommend;

        public void GetData()
        {
            throw new NotImplementedException();
        }

        public void SetData()
        {
            throw new NotImplementedException();
        }
    }
}
