using System;
using System.Collections.Generic;

namespace Projekt_1___Vinterprojektet;

public abstract class Character
{
    private string name;
    private int hp;
    private int defense;
    private Weapon currentWeapon;
    private Inventory inventory;

    public Character(string name, int hp, int defense)
    {
        this.name = name;
        this.hp = hp;
        this.defense = defense;
        inventory = new Inventory();
    }

    public string GetName()
    {
        return name;
    }

    public int GetHP()
    {
        return hp;
    }

    public void Heal(int amount)
    {
        hp += amount;
        Console.WriteLine(name + " helades med " + amount + " HP.");
    }

    public void TakeDamage(int amount)
    {
        int actualDamage = amount - defense;
        if (actualDamage < 0) actualDamage = 0;
        hp -= actualDamage;
        Console.WriteLine(name + " tog " + actualDamage + " skada.");
    }

    public void IncreaseDefense(int amount)
    {
        defense += amount;
        Console.WriteLine(name + " ökade försvar med " + amount);
    }

    public void SetCurrentWeapon(Weapon weapon)
    {
        currentWeapon = weapon;
        Console.WriteLine(name + " equipade " + weapon.GetName());
    }

    public void AddToInventory(Item item)
    {
        inventory.AddItem(item);
    }

    public void UseItem(string itemName)
    {
        inventory.UseItem(itemName, this);
    }

    public void UseItem(string itemName, Character target)
    {
        inventory.UseItem(itemName, target);
    }

    public void ShowInventory()
    {
        inventory.ShowItems();
        Console.WriteLine("Total vikt: " + inventory.GetTotalWeight());
    }
}
