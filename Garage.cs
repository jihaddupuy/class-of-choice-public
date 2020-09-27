using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class Garage 
    {

        public List<Vehicle> ListOfVehicles = new List<Vehicle>();

        public void AddVehicle(Vehicle vehicle)
        {
            ListOfVehicles.Add(vehicle);
        }
        public Vehicle  SelectVehicle()
        {
            int index = 1;

            Console.WriteLine("Please select your Vehicles:");
            foreach (Vehicle vehicle in ListOfVehicles)
            {
                
                index++;
            }

            int indexSelected = Convert.ToInt32(Console.ReadLine());
            return ListOfVehicles[indexSelected - 1];
        }

    }


}
