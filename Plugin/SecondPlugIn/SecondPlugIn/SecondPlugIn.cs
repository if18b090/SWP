using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlugInInterface;

namespace SecondPlugIn
{
    public class SecondPlugIn : IPlugIn
    {
        public void printData()
        {
            Console.WriteLine(PlugInData);
        }

        public void setData(string data)
        {
            PlugInData = data;
        }

        private string PlugInData = "Another PlugIn";
    }
}
