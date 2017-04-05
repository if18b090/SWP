using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protoype
{
    class Program
    {
        static void Main(string[] args)
        {
            SwordManager SwordManager = SwordManager.Instance;
            SwordManager.LoadConfig();

            IPrototype Supersword = SwordManager.GetClone("Longsword");

            Console.ReadKey();
        }
    }
}

