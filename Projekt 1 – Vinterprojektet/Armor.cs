using System;
using System.Collections.Generic;

namespace Projekt_1___Vinterprojektet;

public class Armor : Item
{
    private int defenseBoost;

    public Armor(string name, float weight, int defenseBoost) : base(name, weight)
    {
        this.defenseBoost = defenseBoost;
    }

    public int GetDefenseBoost()
    {
        return defenseBoost;
    }

    public new void Use(Character target)
    {
        target.IncreaseDefense(defenseBoost);
    }
}
