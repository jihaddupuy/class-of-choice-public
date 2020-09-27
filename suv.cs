using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class Suv : Vehicle
    { // properties
        public int BashBar { get; set; }
        public int Lift { get; set; }
        public string Truck { get; set; }


        // constuctor
        public Suv()
        {
            MechanicalLevel = 100;
            FuelLevel = 100;
            TireGrip = 100;
            Armor = 100;
            Suspention = 100;
        }
        public override void Repair()
        {
            MechanicalLevel = 25;
        }
        public override void Refuel()
        {
            FuelLevel = 12;
        }
        public override void ChangeTires()
        {
            TireGrip = 5;
        }
        public override void AddAmor()
        {
            Armor = 22;
        }
        public override void AddHandling()
        {
            Suspention = 15;
        }

        public string GetSuv()//
        {
            return Truck;
        }
        public override void DisplayStatus()
        {

            Console.WriteLine($"Mechanical :{GetMechanicalLevel()}, Gas {GetFuelLevel()}, Armor {GetArmor()}" +
                $", tire Level {GetTireGrip()}, Handling {GetSuspention()}.\n");
        }
    }
}

