using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Choose_Your_Class
{
    public class Vehicle
    { // properties 
        public string Make { get; set; }
        public string Model { get; set; }
        public int MechanicalLevel { get; set; }
        public int FuelLevel { get; set; }
        public int TireGrip { get; set; }
        public int Armor { get; set; }
         public int Suspention { get; set; }
        public Vehicle()
        {
            
            MechanicalLevel = 100;
            FuelLevel = 100;
            TireGrip = 100;
            Armor = 100;
            Suspention = 100;
        }
        public virtual void SetMake(string make )
        {
            Make = make;
        }
        public virtual string GetMake()
        {
            return Make;
        }
        public virtual void SetModel(string model)
        {
            Model = model;
        }
        public virtual string GetModel()
        {
            return Model;
        }
        public virtual void Repair()
        {
            MechanicalLevel = 25;
        }
        public virtual void Refuel()
        {
            FuelLevel = 12;
        }
        public virtual void ChangeTires()
        {
            TireGrip = 5;
        }
        public virtual void AddAmor()
        {
           Armor = 22;
        }
        public virtual void AddHandling()
        {
            Suspention = 15;
        }

        public virtual int GetMechanicalLevel()
        {
            return MechanicalLevel;
        }

        public virtual int GetFuelLevel()
        {
            return FuelLevel;
        }

        public virtual int GetTireGrip()
        {
            return TireGrip;
        }
        public virtual int GetArmor()
        {
            return Armor;
        }     
        public virtual int GetSuspention()
        {
            return Suspention;
        }
        public virtual void Tick()
        {
            MechanicalLevel -= 5;
            FuelLevel-= 5;
            Armor -= 5;
            TireGrip -= 5;
            Suspention -= 10;   
        }
        public virtual void DisplayStatus()
        {
          Console.WriteLine($"{Make} {Model}:");
          Console.WriteLine($"Mechanical :{GetMechanicalLevel()}, Gas {GetFuelLevel()}, Armor {GetArmor()}" +
            $", tire Level {GetTireGrip()}, Handling {GetSuspention()}.\n");
        }
    }
}
