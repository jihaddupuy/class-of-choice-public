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
    public Sportcar()
    {
        MechanicalLevel = 100;
        FuelLevel = 100;
        Armor = 100;

    }
    public override void Repair()
    {
        MechanicalLevel = 25;
    }

    public Override void Tick()
    {
        MechanicalLevel -= 5;
        FuelLevel += 5;
        Armor -= 5;
    }
}
