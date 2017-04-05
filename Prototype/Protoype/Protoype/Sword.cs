using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protoype
{
    public class Sword : IPrototype
    {
        public string TypeName { get; internal set; }
        public float Weight { get; internal set; }
        public float Length { get; internal set; }
        public int Hitpoints { get; internal set; }
        public string Material { get; internal set; }
        public string Color { get; internal set; }


        public Sword(string typeName, float weight, float length, int hitpoints, string material, string color)
        {
            TypeName = typeName;
            Weight = weight;
            Length = length;
            Hitpoints = hitpoints;
            Material = material;
            Color = color;
        }

        /// <summary>
        /// Returns shallow copy, but since there are no object references in Sword this is fine.
        /// </summary>
        /// <returns></returns>
        public object Clone()
        {
            return (IPrototype)MemberwiseClone();
        }
    }
}
