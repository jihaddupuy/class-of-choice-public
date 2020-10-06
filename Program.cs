using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace Choose_Your_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Garage garage = new Garage();

            Vehicle vehicle = new Vehicle();

            List<Vehicle> listOfVhehicles = new List<Vehicle>();

            Console.WriteLine("welcome to car mods");
            bool vehicleChoice = true;
            while (vehicleChoice)
            {
                Console.WriteLine(" Pick Your vehicle ");
                Console.WriteLine("1. Create a new Sports car");
                Console.WriteLine("2. create a new Suv");
                Console.WriteLine("3. Repair");
                Console.WriteLine("4. add gas");
                Console.WriteLine("5. Change tires");
                Console.WriteLine("6. Add armor");
                Console.WriteLine("7. improve Handling");
                Console.WriteLine("8. display vehicle status");
                Console.WriteLine("9. Quit");
                string menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        Console.WriteLine("you have selected a sports car");
                        Console.WriteLine("what is the make of your Sports car?");
                        string make = Console.ReadLine();
                        Console.WriteLine("what is the model of your sports car?");
                        string model = Console.ReadLine();
                        vehicle = new SportsCar(make, model);
                        garage.AddVehicle(vehicle);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("you have selected a Suv");
                        Console.WriteLine("what is the make of your Suv?");
                         make = Console.ReadLine();
                        Console.WriteLine("what is the model of your suv?");
                         model = Console.ReadLine();
                        vehicle = new Suv(make, model);
                        garage.AddVehicle(vehicle);
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("you have repaired your vehicle");
                        vehicle.Repair();
                        vehicle.Tick();
                        break;
                    case "4":
                        Console.WriteLine("you have refueled your vehicle");
                        vehicle.Refuel();
                        vehicle.Tick();
                        break;
                    case "5":
                        Console.WriteLine("you have changed the tires on your vehicle");
                        vehicle.ChangeTires();
                        vehicle.Tick();
                        break;
                    case "6":
                        Console.WriteLine("you have added armor on your vehicle");
                        vehicle.AddAmor();
                        vehicle.Tick();
                        break;
                    case "7":
                        Console.WriteLine("you have improved your handling on your vehicle");
                        vehicle.AddHandling();
                        vehicle.Tick();
                        break;
                    case "8":
                        foreach (Vehicle vehicle1 in garage.ListOfVehicles)
                        {
                            vehicle1.DisplayStatus();
                            vehicle.Tick();
                        }
                        Console.WriteLine("status");
                        break;
                    case "9":
                        vehicleChoice = false;
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
}
