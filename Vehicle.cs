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


        //constructor
        public Vehicle()
        {
            MechanicalLevel = 100;
            FuelLevel = 100;
            Armor = 100;

        }
        public void Repair()
        {
            MechanicalLevel = 25;
        }
        public void Tick()
        {
            MechanicalLevel -= 5;
            FuelLevel+= 5;
            Armor -= 5;
        }

        public virtual void DisplayStatus()
        {
        Console.WriteLine($"{Name}  {Species}:");
        Console.WriteLine($"Hunger:{GetHunger()}, Boredom {GetBoredom()}, Pet Health {GetHealth()}.\n");
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