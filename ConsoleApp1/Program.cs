// Psuedokod:

// Player Stats:
int hp = 0;
int maxhp = 0;
int damageMax = 0;
int damageMin = 0;
string name = "";

// Lancer:
float moreDMG;

// Enemies:
int testHP = 1000;
int EminDMG = 100;
int EmaxDMG = 500;


Console.WriteLine("""
Choose Your Chacter:

""");
Thread.Sleep(500);

Console.WriteLine("""
Knight (1)
Weapon = Sword and Shield (125 - 175 Damage)
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
Ability: Ground Slam
HP 3000
Trait: 25% Chance to Miss Your Attack Completely

""");


string answer = Console.ReadLine();
int result = 0;
bool isNumber = int.TryParse(answer, out result);
while (isNumber != true || result > 3 || result < 1)
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
    maxhp = 1000;
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
    maxhp = 750;
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
    maxhp = 3000;
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
Console.ReadLine();


// TESTA SÅ ATT DMG OCH HP OCH ABILITIES FUNKAR!!!
Random trL = new Random();
Random trT = new Random();
moreDMG = 1.8f;


while (true)
{
    Console.Clear();
    Console.WriteLine($"Enemy HP = {testHP}");
    Console.WriteLine("Press ENTER to Damage");
    Console.ReadLine();

    bool trLbool = trL.NextDouble() < 0.35;
    bool trTbool = trT.NextDouble() < 0.25;
    if (name == "Lancer")
    {
        if (trLbool == true)
        {
            testHP -= (int) MathF.Round(Random.Shared.Next(damageMin, damageMax) * moreDMG);
            Console.WriteLine("Ability Active!");
        }
        else
        {
            testHP -= Random.Shared.Next(damageMin, damageMax);
        }
    }
    if (name == "Titan")
    {
        if (trTbool == true)
        {
            testHP -= 0;
            Console.WriteLine("Miss!");
        }
        else
        {
            testHP -= Random.Shared.Next(damageMin, damageMax);
        }
    }

    hp -= Random.Shared.Next(EminDMG, EmaxDMG);

    Console.WriteLine($"Enemy HP = {testHP}");
    testHP = 1000 - testHP;
    Console.WriteLine($"You did {testHP} Damage");
    testHP = 1000;
    Console.WriteLine($"Your HP = {hp}");
    // maxhp -= hp;
    Console.WriteLine($"Enemy did {}");

    Console.ReadLine();
}

// FIXA SÅ ATT TEST KAN GÖRA SKADA PÅ SPELAREN
// FIXA KNIGHT TRAIT

