using System;
using Projekt_1___Vinterprojektet;

Console.WriteLine("Välkommen till spelet, din gloriosa kung Lebron!");
Console.Write("Skriv in namnet på din karaktär: ");
string characterName = Console.ReadLine();

Character player = null;

while (player == null)
{
    Console.WriteLine("Välj kön:");
    Console.WriteLine("1. Kvinna");
    Console.WriteLine("2. Man");

    string choice = Console.ReadLine();

    if (choice == "1")
    {
        player = new FemaleCharacter(characterName);
    }
    else if (choice == "2")
    {
        player = new MaleCharacter(characterName);
    }
    else
    {
        Console.WriteLine("fel val, försök igen.");
    }
}

// Skapa en fiende
Enemy enemy = new Enemy("Orc", 100, 5);
Console.WriteLine($"En fiende dyker upp: {enemy.GetName()}!");

// Skapa föremål
Weapon sword = new Weapon("Svärd", 5, 15);
Armor shield = new Armor("Sköld", 3, 10);
Potions potion = new Potions("Hälsodryck", 1, 20);

// Lista av tillgängliga föremål
List<Item> availableItems = new List<Item> { sword, shield, potion };
int itemsTaken = 0;

// huvudmeny innan strid
while (itemsTaken < 3)
{
    Console.WriteLine("Vad vill du göra?");
    Console.WriteLine("1. Ta ett föremål");
    Console.WriteLine("2. Gå till strid");

    string input = Console.ReadLine();

    if (input == "1")
    {
        Console.WriteLine("Välj ett föremål att ta:");
        for (int i = 0; i < availableItems.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {availableItems[i].GetName()}");
        }

        string itemChoice = Console.ReadLine();
        if (int.TryParse(itemChoice, out int index) && index >= 1 && index <= availableItems.Count) // satsen kollar om användaren skrev en siffra, och om den siffran motsvarar ett giltigt val i listan.
        {
            Item selectedItem = availableItems[index - 1];
            player.AddToInventory(selectedItem);
            availableItems.RemoveAt(index - 1);
            itemsTaken++;
        }
        else
        {
            Console.WriteLine("Ogiltigt val.");
        }
    }
    else if (input == "2" && itemsTaken == 3)
    {
        break;
    }
    else
    {
        Console.WriteLine("Du måste ta alla 3 föremål innan du kan slåss.");
    }
}

// visa inventory före strid
Console.WriteLine("Dags för strid!");
player.ShowInventory();


// strid
bool fightOngoing = true;

while (fightOngoing)
{
    Console.WriteLine("vad vill du göra?");
    Console.WriteLine("1. använd föremål på dig själv");
    Console.WriteLine("2. använd föremål på fienden");
    Console.WriteLine("3. visa inventory");
    Console.WriteLine("4. avsluta strid");

    string action = Console.ReadLine();

    
    if (action == "1")
    {
        Console.Write("ange föremålsnamn: ");
        string selfItem = Console.ReadLine();
        player.UseItem(selfItem);
    }

    else if (action == "2")
    {
        Console.Write("ange föremålsnamn: ");
        string targetItem = Console.ReadLine();
        player.UseItem(targetItem, enemy);
    }

    else if (action == "3")
    {
        player.ShowInventory();
    }

    else if (action == "4")
    {
        fightOngoing = false;
    }
    
    else if (action == "5")
    {
        Console.WriteLine("fel val.");
    }
    

    // Fienden attackerar efter varje drag
    if (enemy.GetHP() > 0)
    {
        enemy.Attack(player);
    }

    if (player.GetHP() <= 0)
    {
        Console.WriteLine($"{player.GetName()} dog. Spelet är över.");
        fightOngoing = false;
    }
    else if (enemy.GetHP() <= 0)
    {
        Console.WriteLine($"{enemy.GetName()} är besegrad! Du vann.");
        fightOngoing = false;
    }
}

Console.WriteLine("fin");