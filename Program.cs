using System;
using System.Collections.Generic;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();

            Vehicle vehicle = new Vehicle();

            Suv suv = new Suv ();

            SportsCar sportscar = new SportsCar();

            List<Vehicle> listOfVhehicles = new List<Vehicle>();



            Console.WriteLine("welcome to car mods");


            Console.WriteLine("1. Pick Your vehicle ");
            Console.WriteLine("2. Create a new Sports car");
            Console.WriteLine("3. create a new suv");
            Console.WriteLine("4. ReFuel");
            Console.WriteLine("5. RePair");
            Console.WriteLine("6. Display Sports car status");
            Console.WriteLine("7. Quit");

            string menuChoice = Console.ReadLine();
            switch (menuChoice)
            {
                case "2":
                    Console.WriteLine("you have selected a sports car");
                    vehicle = new SportsCar();
                    garage.AddVehicle(vehicle);
                    Console.ReadKey();
                    break;
                case "3":
                    Console.WriteLine("you have selected a Suv");
                    vehicle = new Suv();
                    garage.AddVehicle(vehicle);
                    Console.ReadKey();
                    break;
                case "4":
                    suv.DisplayStatus();
                    Console.WriteLine("suv Status");
                    
                       
                    
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Invalid entry.");
                    break;
            }
            Console.WriteLine("Press Enter to continue.");
            Console.ReadKey();
            Console.Clear();

        }
    }
}
