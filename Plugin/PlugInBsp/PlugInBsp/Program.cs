using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Permissions;

namespace PlugInBsp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Manager = PlugInManager.GetInstance();

            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = Directory.GetCurrentDirectory() + "\\PlugIns";
            watcher.Filter = "*.dll";
            watcher.Created += new FileSystemEventHandler(OnChanged);

            Manager.initialize();
            Console.WriteLine("Initializing\n");

            foreach (var PlugIn in Manager.PlugInList)
            {                
                Console.WriteLine("Found PlugIn: " + PlugIn.GetType().Name);
                PlugIn.printData();
            }

            watcher.EnableRaisingEvents = true;


            Console.WriteLine("Press \'q\' to quit");
            while (Console.Read() != 'q') ;

        }
        private static void OnChanged(object source, FileSystemEventArgs e)
        {
            Console.WriteLine("File: " + e.Name + " " + e.ChangeType);
            var Manager = PlugInManager.GetInstance();
            Manager.addPlugIn(e.FullPath);
        }
    }
}
