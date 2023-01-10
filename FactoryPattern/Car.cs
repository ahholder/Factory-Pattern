using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    public class Car: IVehicle
    {
        public string Name { get; set; } = "Car";
        public int Tires { get; set; } = 4;
        public void Drive()
        {
            Console.WriteLine($"Building a new {Name}!");
        }
    }
}
