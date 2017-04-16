using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlugInInterface
{
    public interface IPlugIn
    {
        void setData(string data);
        void printData();
    }
}
