using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Motorcycle: IVehicle
    {
        public string Name { get; set; } = "Motorcycle";
        public int Tires { get; set; } = 2;
        public void Drive()
        {
            Console.WriteLine($"Building a new {Name}!");
        }
    }
}
