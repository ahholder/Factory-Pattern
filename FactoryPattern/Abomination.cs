using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Abomination: IVehicle
    {
        public string Name { get; set; } = "Abomination";
        public int Tires { get; set; }
        public void Drive()
        {
            if (Tires != 1) Console.WriteLine($"I don't know what has {Tires} wheels but, whatever it is, it isn't street legal...");
            if (Tires == 1) Console.WriteLine($"I don't know what has {Tires} wheel but, whatever it is, it isn't street legal...");
        }
    }
}
