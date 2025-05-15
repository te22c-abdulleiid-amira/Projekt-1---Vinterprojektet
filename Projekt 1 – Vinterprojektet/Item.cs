using System;
using System.Collections.Generic;

namespace Projekt_1___Vinterprojektet;


public abstract class Item
{
    // namnet på item
    private string name;

    // vikten av item
    private float weight;

    // metod som sätter namn och vikt
    public Item(string name, float weight)
    {
        this.name = name;
        this.weight = weight;
    }

    // returnerar namnet
    public string GetName()
    {
        return name;
    }

    // returnerar vikten
    public float GetWeight()
    {
        return weight;
    }

    // metod som används när item används på en karaktär
    public void Use(Character target)
    {

    }
}
