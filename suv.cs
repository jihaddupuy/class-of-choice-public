using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{ // properties
    public class Suv : Vehicle
    { // properties
        //public int BashBar { get; set; }
       // public int Lift { get; set; } <--DLC
        public Suv(string make, string model)
        { //constuctor
            Model = model;
            Make = make;
            MechanicalLevel = 100;
            FuelLevel = 100;
            TireGrip = 100;
            Armor = 100;
            Suspention = 100;
        }
        //methods and objects
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
            MechanicalLevel = 25;
        }
        public override void Refuel()
        {
            FuelLevel = 12;
        }
        public override void ChangeTires()
        {
            TireGrip = 14;
        }
        public override void AddAmor()
        {
            Armor = 22;
        }
        public override void AddHandling()
        {
            Suspention = 15;
        }
        public void TickSuv()
        {
            MechanicalLevel -= 5;
            FuelLevel -= 3;
            TireGrip-= 5;
            Armor -=2;
            Suspention -= 6;
        }
        public override void DisplayStatus()
        {
            Console.WriteLine($"{Make} {Model}:");
            Console.WriteLine($"Mechanical :{GetMechanicalLevel()}, Gas {GetFuelLevel()}, Armor {GetArmor()}" +
                $", tire Level {GetTireGrip()}, Handling {GetSuspention()}.\n");
        }
    }
}

