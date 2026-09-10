namespace Prog_Les1;
using System.Linq;

public class Opdrachten
{
    public Opdrachten()
    {
        Console.WriteLine("Opdracht 1:");
        Opdracht1komma1();
        Console.WriteLine("Opdracht 2:");
        Opdracht1komma2();
        Console.WriteLine("Opdracht 3:");
        Begroeting("niklas");
        Console.WriteLine("Opdracht 4:");
        int result = Max(25, 25);
        Console.WriteLine(result);
        Console.WriteLine("Opdracht 5:");
        int attack = BerekenSchade(25, 45);
        Console.WriteLine(attack);
        Console.WriteLine("Opdracht 6:");
        Opdracht1komma6();
        Console.WriteLine("Opdracht 7:");
        Opdracht1komma7();
        Console.WriteLine("Opdracht 8:");
        Opdracht1komma8();
        Console.WriteLine("Opdracht 9:");
        Player player1 = new Player("jeff", 100, 25);
        Opdracht1komma9(player1);
        Console.WriteLine("Opdracht 10:");
        Player player = new Player("jeff", 100, 25);
        Player player2 = new Player("bezos", 20, 999);
        Player player3 = new Player("arnold", 21, 22);
        Player[] players = {player, player2, player3};
        Opdracht1komma10(players);
        Console.WriteLine("Opdracht 11:");
        Opdracht1komma11();
    }
    private void Opdracht1komma1()
    {
        string name = "Niklas";
        int score = 28;
        bool isAlive = true;
        Console.WriteLine(name);
        Console.WriteLine(score);
        Console.WriteLine(isAlive);
    }

    private void Opdracht1komma2()
    {
        int HP = 100;
        HP -= 35;
        Console.WriteLine(HP);
        if(HP > 0)
        {
            Console.WriteLine("player leeft nog");
        }
        else
        {
            Console.WriteLine("Player is dead");
        }
        HP -= 80;
        Console.WriteLine(HP);
        if(HP > 0)
        {
            Console.WriteLine("player leeft nog");
        }
        else
        {
            Console.WriteLine("Player is dead");
        }
    }

    private void Begroeting(string name) // Opdracht 1 komma 3
    {
        Console.WriteLine("Hoi " + name);
    }

    private static int Max(int a, int b) // Opdracht 1 komma 4
    {
        if (a >= b)
        {
            return a;
        }

        return b;
    }

    private static int BerekenSchade(int attack, int defense) // Opdracht 1 komma 5
    {
        int newattack = attack - defense;
        if(newattack <= 0)
        {
            return 0;
        }
        return newattack;
    }

    private void Opdracht1komma6()
    {
        string[] enemys = {"Tank","Ork","Archer","Knight","Ogre"};
        for (int i = 0; i < enemys.Length; i++)
        {
            Console.WriteLine(enemys[i]);
        }
    }

    private void Opdracht1komma7()
    {
        int[] scores = {4, 6, 20, 99, 9};
        Console.WriteLine(scores.Max());
    }

    private void Opdracht1komma8()
    {
        Player player1 = new Player("jeff", 100, 25);
        player1.PrintInfo();
        Player player2 = new Player("bezos", 20, 999);
        player2.PrintInfo();
        Player player3 = new Player("arnold", 21, 22);
        player3.PrintInfo();
    }

    private void Opdracht1komma9(Player player)
    {
        player.Vertel();
    }

    private void Opdracht1komma10(Player[] players)
    {
        foreach (Player player in players)
        {
            player.Vertel();
        }
    }


    class Player
    {
        public string Naam;
        public int HP;
        public int Score;
        public Player(string name, int HP, int score)
        {
            Naam = name;
            this.HP = HP;
            Score = score;
        }

        public void PrintInfo()
        {
            Console.WriteLine(Naam);
            Console.WriteLine(HP);
            Console.WriteLine(Score);
        }

        public void Vertel()
        {
            Console.WriteLine($"Ik ben {Naam}, mijn HP is {HP} en mijn score is {Score}");
        }
    }

    private void Opdracht1komma11()
    {
        List<string> EnemyNames = new List<string>();
        EnemyNames.Add("ork");
        EnemyNames.Add("archer");
        EnemyNames.Add("mage");
        EnemyNames.Add("knight");
        EnemyNames.Add("devil");
        
        EnemyNames.Remove("devil");

        foreach (string enemy in EnemyNames)
        {
            Console.WriteLine(enemy);
        }
        Console.WriteLine(EnemyNames.Count);
    }
}