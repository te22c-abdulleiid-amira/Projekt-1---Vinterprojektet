using System;

namespace Projekt_1___Vinterprojektet;

public class Potions : Items
{
    private int HealAmount { get; private set; }

    public Potions(string name, float weight, int healAmount) : base(name, weight)
    {
        HealAmount = healAmount;
    }

    public override void Use()
    {
        Console.WriteLine($"{Name} återställer {HealAmount} HP.");
    }
}
