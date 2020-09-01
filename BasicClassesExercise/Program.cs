using System;

namespace BasicClassesExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "Lexus";
            car.Model = "RX350";
            car.Year = 2021;

            Console.WriteLine($"The Make of my next car is a {car.Make} SUV.");
            Console.WriteLine($"The {car.Make} will be of the {car.Model} Model,");
            Console.WriteLine($"and the Year of the SUV will be {car.Year}.");
        }
    }
}
