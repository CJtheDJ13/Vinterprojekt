// Psuedokod:

// Player Stats:
int playerDMG = 0;
int hp = 0;
int damageMax = 0;
int damageMin = 0;
string name = "";

// Knight:
int HealthBoost = 0;
int healingMin = 0;
int healingMax = 100;

// Lancer:
float moreDMG;
int spearThrowDMG;

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
-----------------------------------------------------------------------
Knight (1)
Weapon: Sword and Shield (125 - 175 Damage)
Ability: Healing (15 - 150 HP)
HP: 1000
Trait: 20% Chance to Completely Block the Enemy's Attack
-----------------------------------------------------------------------
Lancer (2)
Weapon: Spear (90 - 125 Damage)
Ability: Throw Spear (15% Chance to do 450 Damage)
HP: 750
Trait: 35% Chance to do 80% More Damage
-----------------------------------------------------------------------
Titan (3)
Weapon: Huge Sword (225 - 300 Damage)
Ability: Ground Slam (75 Damage)
HP: 3000
Trait: 50% Chance to Miss Your Attack Completely
-----------------------------------------------------------------------

Type 1, 2 or 3

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


Random trK = new Random(); //Knight
Random trL = new Random(); //Lancer
Random trLSpecial = new Random(); //LancerSpecialAbility
Random trT = new Random(); //Titan
moreDMG = 1.8f; //Lancer
spearThrowDMG = 450;

while (true)
{
    Console.Clear();
    // Console.WriteLine("Press ENTER to Continue");
    // Console.ReadLine();

    bool trKbool = trK.NextDouble() < 0.20;
    bool trLbool = trL.NextDouble() < 0.35;
    bool trLSpeacialbool = trLSpecial.NextDouble() < 0.15;
    bool trTbool = trT.NextDouble() < 0.5;

    if (name == "Knight")
    {
        Console.WriteLine("Choose Your Move:");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1 = Attack");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("2 = Special Ability");
        Console.ResetColor();
        Console.WriteLine("");
        string move = Console.ReadLine();
        while (move != "1" && move != "2")
        {
            Console.WriteLine("Type 1 or 2");
            move = Console.ReadLine();
        }
        if (move == "1")
        {
            playerDMG = Random.Shared.Next(damageMin, damageMax);
        }
        else if (move == "2")
        {
            HealthBoost = Random.Shared.Next(healingMin, healingMax);
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"""
            Healed {HealthBoost} HP!
            """);
            Console.ResetColor();
            hp += HealthBoost;
            playerDMG = 0;
        }
        Console.ForegroundColor = ConsoleColor.Green;
        if (trKbool == true)
        {
            Console.WriteLine("""

            Blocked Enemy Attack!
            """);
        }
        Console.ResetColor();
    }
    if (name == "Lancer")
    {
        Console.WriteLine("Choose Your Move:");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1 = Attack");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("2 = Special Ability");
        Console.ResetColor();
        Console.WriteLine("");
        string move = Console.ReadLine();
        while (move != "1" && move != "2")
        {
            Console.WriteLine("""
            Type 1 or 2
            
            """);
            move = Console.ReadLine();
        }
        if (move == "1")
        {
        if (trLbool == true)
            {
                playerDMG = (int) MathF.Round(Random.Shared.Next(damageMin, damageMax) * moreDMG);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("""

                Damage Boost!

                """);
                Console.ResetColor();
            }
            else
            {
                playerDMG = Random.Shared.Next(damageMin, damageMax);
            }
        }
        if (move == "2")
        {
        if (trLSpeacialbool == true)
            {
                playerDMG = spearThrowDMG;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("""

                Succesful Throw!
                
                """);
                Console.ResetColor();
            }
            else
            {
                playerDMG = 0;
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("""

                Miss!
                
                """);
                Console.ResetColor();
            }
            
        }
    }
    if (name == "Titan")
    {
        Console.WriteLine("Choose Your Move:");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("1 = Attack");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("2 = Special Ability");
        Console.ResetColor();
        Console.WriteLine("");
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
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("""
            
            Miss!
            
            """);
            Console.ResetColor();
        }
            else
        {
            playerDMG = Random.Shared.Next(damageMin, damageMax);
        }
        }
        if (move == "2")
        {
            playerDMG = 75;
        }
    }

    enemyDMG = Random.Shared.Next(EminDMG, EmaxDMG);
    enemyHP -= playerDMG;

    if (name == "Knight" && trKbool == true)
    {
        enemyDMG = 0;
    }

    hp -= enemyDMG;
    hp = Math.Max(0, hp);
    enemyHP = Math.Max(0, enemyHP);

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine($"""

    You did {playerDMG} Damage    
    """);
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"""
    Enemy did {enemyDMG} Damage
    
    """);
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Your HP = {hp}");
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine($"Enemy HP = {enemyHP}");
    Console.ResetColor();

    Console.ReadLine();
}

