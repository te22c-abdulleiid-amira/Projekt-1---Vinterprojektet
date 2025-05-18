using System;
using Projekt_1___Vinterprojektet;

Console.WriteLine("Välkommen till spelet, din gloriosa kung Lebron!");
Console.Write("Skriv in namnet på din karaktär: ");
string playerName = Console.ReadLine();

Character player;

while (true)
{
    Console.Write("Välj kön på din karaktär (skriv female/male): ");
    string gender = Console.ReadLine().ToLower();

    if (gender == "female")
    {
    player = new FemaleCharacter(playerName);
    break; // break avslutar loop- eller switch-satser
    }
    else if (gender == "male")
    {
        // Byt ut mot MaleCharacter när den finns
        player = new FemaleCharacter(playerName);
        break;
    }
    else
    {
        Console.WriteLine("Felaktigt val, försök igen.");
    }
}

Weapon sword = new Weapon("svärd", 10, 15);
Potions potion = new Potions("medicin", 10, 20);
Armor shield = new Armor("sköld", 10, 5);

// lägg till items i spelarens inventory
player.AddToInventory(sword);
player.AddToInventory(potion);
player.AddToInventory(shield);

// visa inventory
player.ShowInventory();
// använd ett item (exempel: använda potion på sig själv)
Console.WriteLine("\nAnvänder Liten hälsodryck på dig själv:");
player.UseItem("Liten hälsodryck");

// använd ett annat item (exempel: equipa svärd)
Console.WriteLine("\nEquipa Svärd:");
player.UseItem("Svärd");

// akapa en fiende
Enemy enemy = new Enemy("Dark Reunion attackerar", 80, 8);

// fienden attackerar spelaren
enemy.Attack(player);

// visa spelarens HP efter attacken
Console.WriteLine($"{player.GetName()} har {player.GetHP()} HP kvar.");

    
Console.WriteLine("\nTryck på valfri tangent för att avsluta.");
Console.ReadKey();

