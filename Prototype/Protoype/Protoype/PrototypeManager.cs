using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Protoype
{
    public class SwordManager : IPrototypeManager
    { 
        protected static SwordManager instance = new SwordManager();
        protected SwordManager() { }
        public static SwordManager Instance
        {
            get
            {
                return instance;
            }
        }

        private Dictionary<string, IPrototype> PrototypeDictionary = new Dictionary<string, IPrototype>();

        public void LoadConfig()
        {
            using (var fs = File.OpenRead(@"C:\Users\Verena\Desktop\SWP\Prototype\Protoype\Protoype\SwordConf.csv"))
            using (var reader = new StreamReader(fs))
            {
                reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    string[] values = line.Split(',');
                    MakeInstance(values);
                }
            }
        }

        private void MakeInstance(string[] values)
        {
            string TypeName = values[0];
            float Weight = float.Parse(values[1]);
            float Length = float.Parse(values[2]);
            int Hitpoints = int.Parse(values[3]);
            string Material = values[4];
            string Color = values[5];

            AddInstanceToDictionary(new Sword(TypeName, Weight, Length, Hitpoints, Material, Color));
        }

        private void AddInstanceToDictionary(Sword sword)
        {
            PrototypeDictionary.Add(sword.TypeName, sword);
        }

        public IPrototype GetClone(string TypeName)
        {
            #if DEBUG
                Console.WriteLine("New " + TypeName + " cloned.");
            #endif
            return PrototypeDictionary[TypeName].Clone() as Sword;
        }
    }
 }
