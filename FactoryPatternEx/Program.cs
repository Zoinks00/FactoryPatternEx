using System;

namespace FactoryPatternEx
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter 4 or 16 to do a search by wheel count for vehicle that can be made.");
            Console.WriteLine("Search will be done by default for vehicle with 4 wheels.");
            int wheelCount;
            var userInput = int.TryParse(Console.ReadLine(), out wheelCount);
            
            var myBuild = FactoryVehicle.GetVehicle(wheelCount);

            myBuild.Drive();

        }
    }
}
