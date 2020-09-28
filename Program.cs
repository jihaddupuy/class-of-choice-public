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
            bool vehicleChoice = true;
            while (vehicleChoice)
            {



                Console.WriteLine(" Pick Your vehicle ");
                Console.WriteLine("1. Create a new Sports car");
                Console.WriteLine("2. create a new suv");
                Console.WriteLine("3. Repair");
                Console.WriteLine("4. add gas");
                Console.WriteLine("5. Change tires");
                Console.WriteLine("6. Add armor");
                Console.WriteLine("7. improve Handling");
                Console.WriteLine("8. display sports car status");
                Console.WriteLine("9. display suv status");
                Console.WriteLine("10. Quit");

                string menuChoice = Console.ReadLine();
                switch (menuChoice)
                {
                    case "1":
                        Console.WriteLine("you have selected a sports car");
                        vehicle = new SportsCar();
                        garage.AddVehicle(vehicle);
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("you have selected a Suv");
                        vehicle = new Suv();
                        garage.AddVehicle(vehicle);
                        Console.ReadKey();
                        break;
                    case "3":
                        vehicle.Repair();
                        break;
                    case "4":
                        vehicle.Refuel();
                        break;
                    case "5":
                        vehicle.ChangeTires();
                        break;
                    case "6":
                        vehicle.AddAmor();
                        break;
                    case "7":
                        vehicle.AddHandling();
                        break;
                    case "8":
                        sportscar.DisplayStatus();
                        Console.WriteLine("sports car status");
                        break;
                    case "9":
                        suv.DisplayStatus();
                        Console.WriteLine("suv Status");
                        Console.ReadKey();
                        break;
                    case "10":
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
