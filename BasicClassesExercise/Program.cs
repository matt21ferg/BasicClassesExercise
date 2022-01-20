using System;

namespace BasicClassesExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myCar = new Cars();
            myCar.model = "Jimmy";
            myCar.make = "GMC";
            myCar.year = 1998;
            Console.WriteLine($"{ myCar.model} {myCar.year} { myCar.make}");
            
        }
    }
}
