using System;

namespace Projekt_1___Vinterprojektet;

public class Potions : Items
{
    public int HealAmount { get; }

    public Potions(string name, float weight, int healAmount) 
        : base(name, weight)
    {
        HealAmount = healAmount;
    }

    public override void Use(Character target)
    {
        
    }
}
