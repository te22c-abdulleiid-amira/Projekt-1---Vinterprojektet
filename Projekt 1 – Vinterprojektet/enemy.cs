using System;

namespace Projekt_1___Vinterprojektet;

public class Enemy : Character
{
 public Enemy(string name, int hp, int defense) : base(name, hp, defense)
    {
    }

    // Fienden attackerar spelaren
    public void Attack(Character target)
    {
        Console.WriteLine($"{GetName()} attackerar {target.GetName()}!");
        target.TakeDamage(10);
    }
}
