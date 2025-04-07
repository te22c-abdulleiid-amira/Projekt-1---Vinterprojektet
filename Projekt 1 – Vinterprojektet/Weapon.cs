using System;
using System.Collections.Generic;

namespace Projekt_1___Vinterprojektet;

public class Weapon : Items
{
    public int Damage { get; }

    public Weapon(string name, float weight, int damage) 
        : base(name, weight)
    {
        Damage = damage;
    }

    public override void Use(Character target)
    {
        
    }
}
