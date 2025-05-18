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
        if (hp > 100) hp = 100;
        Console.WriteLine($"{name} har nu {hp} HP.");
    }
    // max 100 heal

    public void TakeDamage(int amount)
    {
        
        hp -= amount;
        if (hp < 0) hp = 0;
        Console.WriteLine($"{name} tog {amount} skada och har nu {hp} HP.");
    }
    // min 0 damage

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
