using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace Choose_Your_Class
{
    public class Vehicle
    { // properties 
        public int MechanicalLevel { get; set; }
        public int FuelLevel { get; set; }
        public int TireGrip { get; set; }
        public int Armor { get; set; }
         public int Suspention { get; set; }


        //constructor
        public Vehicle()
        {
            MechanicalLevel = 100;
            FuelLevel = 100;
            TireGrip = 100;
            Armor = 100;
            Suspention = 100;
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
            FuelLevel+= 5;
            Armor -= 5;
            TireGrip -= 5;
            Suspention -= 10;
           
        }

        public virtual void DisplayStatus()
        {
       
        Console.WriteLine($"Mechanical :{GetMechanicalLevel()}, Gas {GetFuelLevel()}, Armor {GetArmor()}" +
            $", tire Level {GetTireGrip()}, Handling {GetSuspention()}.\n");
        }
    }
}


//string[] CarClass = new string[7];

//CarClass[0] = "not a option";
//CarClass[1] = "4X4";
//CarClass[4] = "Hatchback";
//CarClass[6] = "Sourdough Bread";

//Console.WriteLine("I just want " + Carclass[4] + "!!");
//Console.ReadKey();

//for (int i = 0; i < CarClass.Length; i++)
//{
    //string dinner = Carclass[i];
   // Console.WriteLine(dinner);