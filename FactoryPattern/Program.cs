namespace FactoryPattern
{
    public class Program
    {
        //Main Method - Setup
        static void Main(string[] args)
        {
            int tally = 0;
            while (tally <= 0)
            {
                Console.Write("Number of Vehicles to Build: ");
                string answ = Console.ReadLine();
                if (int.TryParse(answ, out var i) == true) tally = int.Parse(answ);
                if (tally <= 0) Console.WriteLine("Please enter a valid response!");
            }
            VehicleMaker(tally); // calls VehicleFactory
        }
        //Loops multiple vehicle creation
        static void VehicleMaker(int tally) 
        {
            Console.WriteLine("----- ----- ----- ----- -----");
            int wheels = 0;
            string inputz = "";
            for (var i = 0; i < tally; i++)
            {
                wheels = 0;
                while (wheels <= 0)
                {
                    Console.Write($"#{i + 1}. Enter Number of Wheels: ");
                    inputz = Console.ReadLine();
                    if (int.TryParse(inputz, out var i2) == true) wheels = int.Parse(inputz);
                    if (wheels <= 0) Console.WriteLine("Please enter a valid response!");
                }
                Console.WriteLine("----- ----- ----- ----- -----");
                IVehicle thing = VehicleFactory(wheels);
                thing.Drive();
                Console.WriteLine("----- ----- ----- ----- -----");
            }
        }
        //Completes Factory Pattern Assignment
        static IVehicle VehicleFactory(int wheels)
        {
            switch (wheels)
            {
                case 4:
                    return new Car();
                case 2:
                    return new Motorcycle();
                default:
                    IVehicle thing = new Abomination();
                    thing.Tires = wheels;
                    return thing;
            }
        }
    }
}
