using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class SportsCar : Vehicle
    { //properties 

        // public int Aero { get; set; }
        //public int SportTires { get; set; }  <--DLC  
        public SportsCar(string make, string model)
        {
            Model = model;
            Make = make;
            MechanicalLevel = 100;
            FuelLevel = 100;
            TireGrip = 100;
            Armor = 100;
            Suspention = 100;
        }
        public override void SetMake(string make)
        {
            Make = make;
        }
        public override string GetMake()
        {
            return Make;
        }
        public override void SetModel(string model)
        {
            Model = model;
        }
        public override string GetModel()
        {
            return Model;
        }
        public override void Repair()
        {
            MechanicalLevel = 21;
        }
        public override void Refuel()
        {
            FuelLevel = 25;
        }
        public override void ChangeTires()
        {
            TireGrip = 22;
        }
        public override void AddAmor()
        {
            Armor = 19;
        }
        public override void AddHandling()
        {
            Suspention = 16;
        }
        public void TickCar()
        {
            MechanicalLevel -= 4;
            FuelLevel += 5;
            TireGrip += 3;
            Armor -= 3;
            Suspention -= 7;
        }
        public override void DisplayStatus()
        {
            Console.WriteLine($"{Make} {Model}:");
            Console.WriteLine($"Mechanical :{GetMechanicalLevel()}, Gas {GetFuelLevel()}, Armor {GetArmor()}" +
                $", tire Level {GetTireGrip()}, Handling {GetSuspention()}.\n");
        }
    }
}
