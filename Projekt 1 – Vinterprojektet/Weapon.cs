using System;
using System.Collections.Generic;

namespace Projekt_1___Vinterprojektet;

// Weapon.cs
public class Weapon : Item
{
    private int damage;

    public Weapon(string name, float weight, int damage) : base(name, weight)
    {
        this.damage = damage;
    }

    public int GetDamage()
    {
        return damage;
    }

    public new void Use(Character target)
    {
        target.SetCurrentWeapon(this);
    }
}
