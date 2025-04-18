using System;
using System.Collections.Generic;

namespace Projekt_1___Vinterprojektet;


public class Items
{
    public string Name { get; private set; }
    public float Weight { get; private set; }

    public Items(string name, float weight)
    {
        Name = name;
        Weight = weight;
    }

    public virtual void Use()
    {
        Console.WriteLine($"{Name} används.");
    }

}