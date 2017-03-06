using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            string user = "currentUser";
            Singleton Logger = Singleton.Instance;
            Feature feat = new Feature();

            feat.funOne(user);
            feat.funTwo(user);

            Console.ReadKey();
        }
    }
}
