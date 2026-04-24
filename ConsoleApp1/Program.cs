static void VinterProjekt()
{

// Player Stats:
int playerDMG = 0;
int hp = 0;
int damageMax = 0;
int damageMin = 0;
string name = "";
int kills = 0;
int HealthBoost;

// Knight:
int healingMin = 0;
int healingMax = 125;

// Lancer:
float moreDMG;
int spearThrowDMG;
int LhealingMin = 0;
int LhealingMax = 225;

// Titan:
int TitanHeal = 75;

// Enemy:
int enemyDMG;
List<int> enemyHPlist = [500, 600, 700, 800, 900, 1000, 1100, 1200];
int enemyHP = 0;
int EminDMG = 25;
int EmaxDMG = 150;

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("""
Choose Your Chacter:

""");
Console.ResetColor();
Thread.Sleep(500);
Console.WriteLine("""
-----------------------------------------------------------------------
Knight (1)
Weapon: Sword and Shield (125 - 175 Damage)
Ability: Healing (0 - 125 HP)
HP: 1000
Trait: 20% Chance to Completely Block the Enemy's Attack
-----------------------------------------------------------------------
Lancer (2)
Weapon: Spear (90 - 125 Damage)
Ability: Throw Spear (25% Chance to do 450 Damage + Heals Player 0 - 225 HP)
HP: 750
Trait: 35% Chance to do 80% More Damage 
-----------------------------------------------------------------------
Titan (3)
Weapon: Huge Sword (225 - 300 Damage)
Ability: Ground Slam (75 Damage + 35% Chance to Heal Player 75 HP)
HP: 3000
Trait: 40% Chance to Miss Your Attack Completely
-----------------------------------------------------------------------

""");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("""
Type 1, 2 or 3

""");
Console.ResetColor();


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
    Console.WriteLine($"The {name}! You seem to want to prefer raw Power and Health rather then Agility and Stability!");
    Console.ResetColor();
}

Thread.Sleep(2000);
Console.WriteLine("""

To head into the Arena, Press ENTER
""");
Console.ResetColor();
Console.ReadLine();


Random trK = new Random(); //Knight
Random trL = new Random(); //Lancer
Random trLSpecial = new Random(); //LancerSpecialAbility
Random trT = new Random(); //Titan
Random trTHeal = new Random(); //TitanHeal
spearThrowDMG = 450;
moreDMG = 1.8f; //Lancer

enemyHP += enemyHPlist[Random.Shared.Next(enemyHPlist.Count)];

while (true)
{
    Console.Clear();

    bool trKbool = trK.NextDouble() < 0.20; //Block Attack (Knight)
    bool trLbool = trL.NextDouble() < 0.35; //More DMG (Lancer)
    bool trLSpeacialbool = trLSpecial.NextDouble() < 0.25; //Throw Spear (Lancer)
    bool trTbool = trT.NextDouble() < 0.4; //Miss Attack (Titan)
    bool trTHealbool = trTHeal.NextDouble() < 0.35; //Heal (Titan)

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
                HealthBoost = Random.Shared.Next(LhealingMin, LhealingMax);
                hp += HealthBoost;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"""

                Succesful Throw!
                +
                Healed {HealthBoost} HP
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
            if (trTHealbool == true)
            {
                hp += TitanHeal;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"""

                Healed {TitanHeal} HP!
                """);
                Console.ResetColor();
            }
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
    Console.WriteLine("""

    Press ENTER to continue
    """);
    Console.ReadLine();

    if (hp == 0 && enemyHP > 0)
    {
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Game Over!");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("""
        
        Your final score is 
        """);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{kills}");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("""
         Enemies killed!
        
        """);
        Console.ResetColor();
        Thread.Sleep(1000);
        Console.WriteLine("Press ENTER to Quit");
        Console.ReadLine();
        break;
    }
    else if (enemyHP == 0 && hp > 0)
    {
        Console.Clear();
        kills ++;
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("You have defeated 1 Enemy!");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("""

        A new Enemy is aproaching!

        """);
        enemyHP += enemyHPlist[Random.Shared.Next(enemyHPlist.Count)];
        Console.ResetColor();
        Thread.Sleep(1000);
        Console.WriteLine("Press ENTER to continue");
        Console.ReadLine();
    }
    else if (hp == 0 && enemyHP == 0)
    {
        kills ++;
        Console.Clear();
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.WriteLine("Both contestants have died, Game Over!");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write("""
        
        Your final score is 
        """);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write($"{kills}");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("""
         Enemies killed!
        
        """);
        Console.ResetColor();
        Thread.Sleep(1000);
        Console.WriteLine("Press ENTER to Quit");
        Console.ReadLine();
        break;        
    }
}
}

VinterProjekt();


