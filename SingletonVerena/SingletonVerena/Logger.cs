using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

//Garbage Collector und Singletons: vor Java 1.2 wurden Singletons teilweise vom Garbage Collector vorzeitig eingesammelt, wenn es keine
//globale Referenz gab. Sollte aber seit Java 1.3 nicht mehr passieren.
//In C# ist sowieso alles easy.

//Singletons können nicht abgeleitet werden, wenn der Konstruktor private ist. Von einem protected constructor abzuleiten geht,
//aber man sollte sich genau überlegen, ob dies wirklich notwendig ist.
namespace Singleton
{
    public class Singleton
    {
        /// <summary>
        /// Lazy initalization - Instanz wird erst beim ersten Aufruf erzeugt
        /// Vorsicht: auf die Weise nicht threadsicher!
        /// </summary>
        private static Singleton instance;

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Singleton();
                }
                return instance;
            }
        }

        /*
        /// <summary>
        /// Static initalization - Die Instanz wird schon beim Laden der Klasse erzeugt
        /// Sichert, dass die Instanz schon erzeugt wird, bevor ein Thread darauf zugreifen will
        /// </summary>
        private static Singleton instance = new Singleton();
        private Singleton() { }
        public static Singleton Instance
        {
            get
            {
                return instance;
            }
        }*/

        public void Log(string user)
        {
            DateTime dateTime = DateTime.Now;
            string loginfo = user + " " + dateTime + "\n";
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            path = Path.Combine(path, "SingletonVerena", "logfile.txt");
            WriteToTextfile(path, loginfo);
        }

        private void WriteToTextfile(string fileName, string textToAdd)
        {
            FileStream fs = null;
            fs = new FileStream(fileName, FileMode.Append);
            using (StreamWriter writer = new StreamWriter(fs))
            {
                writer.Write(textToAdd);
            }
        }
    }
}
