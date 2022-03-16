using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternEx
{
    public class Car : IVehicle
    {

        public Car(string make, string model, int year, int wheels)
        {
            Make = make;
        Model = model;
        Year = year;
            Wheels = wheels;
       
        }
        
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }
    public int Wheels { get; set; }
        

        public void Drive()
        {
            Console.WriteLine($"Make = {Make}\nModel = {Model}\nYear = {Year}\nWheels = {Wheels}");
            Console.WriteLine("I am the Knight Rider!");
        }
    }
}
