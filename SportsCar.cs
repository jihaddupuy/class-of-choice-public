using System;
using System.Collections.Generic;
using System.Text;

namespace Choose_Your_Class
{
    class SportsCar : Vehicle
    { //properties 

    public string Aero { get; set; }
    public string SportTires { get; set; }

    }
    //constructor
    public SportCar()
    {
    }
    public Sportscar()
    {
        MechanicalLevel = 100;
        FuelLevel = 100;
        TireGrip = 100;
        Armor = 100;
        Suspention = 100;
    }
    public string GetSportscar()
    {
        return SportsCar;
    }
public override void Repair()
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
