// Psuedokod:

// Player Stats:
int hp = 0;
int damageMax = 0;
int damageMin = 0;
string name = "";

// Knight:
bool block;
// Lancer:
bool moreDMG;
// Titan:
bool miss;

// Enemies:
int test = 500;

Console.WriteLine("""
Choose Your Chacter:

""");
Thread.Sleep(500);

Console.WriteLine("""
Knight (1)
Weapon = Warhammer (125 - 175 Damage)
Ability: 
HP = 1000
Trait: 20% Chance to Completely Block the Enemy's Attack

Lancer (2)
Weapon = Spear (90 - 125 Damage)
Ability:
HP = 750
Trait: 35% Chance to do 80% More Damage

Titan (3)
Weapon = Huge Sword (225 - 300 Damage)
Ability: 
HP 3000
Trait: 25% Chance to Miss Your Attack Completely

""");


string answer = Console.ReadLine();
int result = 0;
bool isNumber = int.TryParse(answer, out result);
while(isNumber != true || result > 3 || result < 1)
{
    Console.ForegroundColor = ConsoleColor.DarkYellow;
    Console.WriteLine("Write a number between 1 and 3!");
    Console.ResetColor();
    answer = Console.ReadLine();
    isNumber = int.TryParse(answer, out result);
}

if (result == 1)
{
    name = "Knight";
    hp = 1000;
    damageMax = 175;
    damageMin = 125;

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Great Choice! The {name} is a Strong Warrior who posseses Great Strength and has a Chance to completely Block an Attack!");
    Console.ResetColor();
}
else if (result == 2)
{
    name = "Lancer";
    hp = 750;
    damageMax = 125;
    damageMin = 90;

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"Interesting Choice! The {name} might be Fragile, but has the Chance to Strike Hard!");
    Console.ResetColor();
}
else if (result == 3)
{
    name = "Titan";
    hp = 3000;
    damageMax = 300;
    damageMin = 225;

    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"The {name}! You seem to want to prefer raw Power and Health rathar then Agility and Stability!");
    Console.ResetColor();
}

Thread.Sleep(2000);
Console.ForegroundColor = ConsoleColor.DarkRed;
Console.Write("""

To head into the Arena, 
""");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("Press: Enter");
Console.ResetColor();


// TESTA SÅ ATT DMG OCH HP OCH ABILITIES FUNKAR!!!



Console.ReadLine();