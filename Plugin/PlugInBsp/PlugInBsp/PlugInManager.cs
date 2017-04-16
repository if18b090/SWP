using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlugInInterface;
using System.IO;
using System.Reflection;

namespace PlugInBsp
{
    class PlugInManager
    {
        private PlugInManager()
        {
        }

        public static PlugInManager GetInstance()
        {
            if (Instance == null)
            {
                Instance = new PlugInManager();
            }

            return Instance;
        }

        public void initialize()
        {
            string path = Directory.GetCurrentDirectory();
            path += "\\PlugIns";
            string[] pluginFiles = Directory.GetFiles(path, "*.dll");

            PlugInList = (
                            // From each file in the files.
                            from file in pluginFiles
                            // Load the assembly.
                            let asm = Assembly.LoadFile(file)
                            // For every type in the assembly that is visible outside of
                            // the assembly.
                            from type in asm.GetExportedTypes()
                            // Where the type implements the interface.
                            where typeof(IPlugIn).IsAssignableFrom(type)
                            // Create the instance.
                            select (IPlugIn)Activator.CreateInstance(type)
                         // Materialize to a list.
                         ).ToList();
        }

        public void addPlugIn(string fileName)
        {
            AssemblyName an = AssemblyName.GetAssemblyName(fileName);
            Assembly assembly = Assembly.Load(an);
            List<Type> types = assembly.GetExportedTypes().ToList();
            Type plugInType = typeof(IPlugIn);

            foreach(var type in types)
            {
                if(typeof(IPlugIn).IsAssignableFrom(type))
                {
                    var newPlugIn = (IPlugIn)Activator.CreateInstance(type);
                    PlugInList.Add(newPlugIn);

                    newPlugIn.printData();
                }
            }            
        }

        private static PlugInManager Instance = null;
        public List<IPlugIn> PlugInList = new List<IPlugIn>();
    }
}
