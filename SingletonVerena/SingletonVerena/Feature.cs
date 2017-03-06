using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Singleton
{
    public class Feature
    {
        public void funOne(string user)
        {
            Console.WriteLine("funOne called");
            Singleton Logger = Singleton.Instance;
            Logger.Log(user);
        }
        public void funTwo(string user)
        {
            Console.WriteLine("funTwo called");
            Singleton Logger = Singleton.Instance;
            Logger.Log(user);
        }

    }
}
