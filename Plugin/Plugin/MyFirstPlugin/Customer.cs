using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PluginInterfaces;

namespace MyFirstPlugin
{
    public class Customer
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        CustomerAddress Address { get; set; }
    }
}
