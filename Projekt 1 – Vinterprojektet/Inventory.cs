using System;

namespace Projekt_1___Vinterprojektet;

public class Inventory
{
    private List<Items> items;
    private float maxWeight;

    public Inventory(float maxWeight)
    {
        this.maxWeight = maxWeight;
        items = new List<Items>();
    }

}
