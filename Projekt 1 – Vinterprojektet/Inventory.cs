using System;
using System.Collections.Generic;

namespace Projekt_1___Vinterprojektet;

public class Inventory
{
    private List<Item> items;

    public Inventory()
    {
        items = new List<Item>();
    }

    public void AddItem(Item item)
    {
        items.Add(item);
        Console.WriteLine(item.GetName() + " lades till i inventory.");
    }

    public void RemoveItem(string itemName)
    {
        Item found = items.Find(i => i.GetName().ToLower() == itemName.ToLower());
        if (found != null)
        {
            items.Remove(found);
            Console.WriteLine(itemName + " togs bort från inventory.");
        }
        else
        {
            Console.WriteLine("Item hittades inte.");
        }
    }

    public void UseItem(string itemName, Character target)
    {
        Item found = items.Find(i => i.GetName().ToLower() == itemName.ToLower());
        if (found != null)
        {
            found.Use(target);
        }
        else
        {
            Console.WriteLine("Item hittades inte.");
        }
    }

    public void ShowItems()
    {
        if (items.Count == 0)
        {
            Console.WriteLine("Inventory är tom.");
        }
        else
        {
            Console.WriteLine("Inventory innehåller:");
            foreach (Item i in items)
            {
                Console.WriteLine("- " + i.GetName());
            }
        }
    }

    public float GetTotalWeight()
    {
        float total = 0;
        foreach (Item item in items)
        {
            total += item.GetWeight();
        }
        return total;
    }
}
