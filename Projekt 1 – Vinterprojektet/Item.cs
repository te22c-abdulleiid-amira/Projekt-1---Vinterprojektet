using System;
using System.Collections.Generic;

namespace Projekt_1___Vinterprojektet;

public abstract class Items
{
   public string Name { get; }
    public float Weight { get; }

    public Items(string name, float weight)
    {
        Name = name;
        Weight = weight;
    }

    public virtual void Use(Character target)
    {
        Console.WriteLine($"{Name} används, men har ingen specifik effekt.");
    }
}

