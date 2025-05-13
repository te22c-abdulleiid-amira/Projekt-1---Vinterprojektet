using System;
using System.Collections.Generic;

namespace Projekt_1___Vinterprojektet;

public class Potions : Item
{
private int healingAmount;

    public Potions(string name, float weight, int healingAmount) : base(name, weight)
    {
        this.healingAmount = healingAmount;
    }

    public int GetHealingAmount()
    {
        return healingAmount;
    }

    public new void Use(Character target)
    {
        target.Heal(healingAmount);
    }
}