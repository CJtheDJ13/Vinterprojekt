// Psuedokod:

// Player Stats:
int playerDMG = 0;
int hp = 0;
int damageMax = 0;
int damageMin = 0;
string name = "";

// Lancer:
float moreDMG;

// Enemie1:
int enemyDMG = 0;
int enemyHP = 1000;
int EminDMG = 50;
int EmaxDMG = 150;


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
Ability: Ground Slam (75 Damage)
HP 3000
Trait: 50% Chance to Miss Your Attack Completely

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
Console.ReadLine();


Random trL = new Random(); //Lancer
Random trT = new Random(); //Titan
moreDMG = 1.8f; //Lancer


while (true)
{
    Console.Clear();
    Console.WriteLine("Press ENTER to Continue");
    Console.ReadLine();

    bool trLbool = trL.NextDouble() < 0.35;
    bool trTbool = trT.NextDouble() < 0.5;
    if (name == "Lancer")
    {
        Console.WriteLine("Choose Your Move:");
        Console.WriteLine("1 = Attack");
        Console.WriteLine("2 = Special Ability");
        string move = Console.ReadLine();
        while (move != "1" && move != "2")
        {
            Console.WriteLine("Type 1 or 2");
            move = Console.ReadLine();
        }

        if (move == "1")
        {
        if (trLbool == true)
        {
            playerDMG = (int) MathF.Round(Random.Shared.Next(damageMin, damageMax) * moreDMG);
            Console.WriteLine("Ability Active!");
            enemyDMG -= playerDMG;
        }
        else
        {
            playerDMG -= Random.Shared.Next(damageMin, damageMax);
            enemyDMG -= playerDMG;
        }
        }
    }
    if (name == "Titan")
    {
        Console.WriteLine("Choose Your Move:");
        Console.WriteLine("1 = Attack");
        Console.WriteLine("2 = Special Ability");
        string move = Console.ReadLine();
        while (move != "1" && move != "2")
        {
            Console.WriteLine("Type 1 or 2");
            move = Console.ReadLine();
        }

        if (move == "1")
        {
            if (trTbool == true)
        {
            playerDMG = 0;
            Console.WriteLine("Miss!");
        }
            else
        {
            playerDMG = Random.Shared.Next(damageMin, damageMax);
            enemyHP -= playerDMG;
        }
        }
        if (move == "2")
        {
            playerDMG = 75;
            enemyHP -= playerDMG;
        }
    }

    enemyDMG = Random.Shared.Next(EminDMG, EmaxDMG);
    hp -= enemyDMG;


    Console.WriteLine($"Your HP = {hp}");
    Console.WriteLine($"Enemy HP = {enemyHP}");
    Console.WriteLine($"You did {playerDMG} Damage");
    Console.WriteLine($"Enemy did {enemyDMG} Damage");

    Console.ReadLine();
}

// FIXA ENEMY DMG OCH ALLA CLASSES

