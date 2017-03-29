using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginInterfaces;

namespace MyFirstPlugin
{
    public class CustomerAddress : IPlugin
    {
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string PostCode { get; set; }
        public string Country { get; set; }

        public void GetData()
        {
            
        }

        public void SetData()
        {
            throw new NotImplementedException();
        }
    }
}
