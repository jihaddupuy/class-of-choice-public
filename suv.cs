using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    public class Suv : Vehicle
    { // properties
        public int BashBar { get; set; }
        public int Lift { get; set; }

    }
    // constuctor
    public Suv()
    {
        public void Repair()
        {
            MechanicalLevel = 25;
        }
        public void Refuel()
        {
            FuelLevel = 12;
        }
        public void AddAmor()
        {
            Armor = 22;
        }
        public void Tick()
        {
            MechanicalLevel -= 5;
            FuelLevel += 5;
            Armor -= 5;
            TireGrip -= 5;
            Suspention -= 10;

        }

        public virtual void DisplayStatus()
        {
        Console.WriteLine($"{Name}  {Species}:");
        Console.WriteLine($"Hunger:{GetHunger()}, Boredom {GetBoredom()}, Pet Health {GetHealth()}.\n");
        }

    }
}

