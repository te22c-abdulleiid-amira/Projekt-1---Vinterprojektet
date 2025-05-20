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
        Console.WriteLine("Ogiltigt val, försök igen.");
    }
}

// skapa en fiende
Enemy enemy = new Enemy("Orc", 100, 5);
Console.WriteLine($"\nEn fiende dyker upp: {enemy.GetName()}!");

// skapa föremål
Weapon sword = new Weapon("Svärd", 5, 15);
Armor shield = new Armor("Sköld", 3, 10);
Potions potion = new Potions("Hälsodryck", 1, 20);

// lägg till i inventory
player.AddToInventory(sword);
player.AddToInventory(shield);
player.AddToInventory(potion);

// visa inventory
player.ShowInventory();

// Välj vapen
player.SetCurrentWeapon(sword);

// Använd rustning (ökar defense)
player.UseItem("Sköld");

// Använd potion (healar spelaren)
player.UseItem("Hälsodryck");

// Fienden attackerar spelaren
enemy.Attack(player);

// Spelaren attackerar fienden
player.UseItem("Svärd", enemy);

// Slutresultat
Console.WriteLine($"\n{player.GetName()} har {player.GetHP()} HP kvar.");
Console.WriteLine($"{enemy.GetName()} har {enemy.GetHP()} HP kvar.");