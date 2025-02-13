using System;

namespace Projekt_1___Vinterprojektet;

public abstract class Items
{
    public string Name { get; private set; }
    public float Weight { get; private set; }

    public Items(string name, float weight)
    {
        Name = name;
        Weight = weight;
    }

}
