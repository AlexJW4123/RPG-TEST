using System;
using System.Xml.Xsl;

public class Program
{
    public static void Main(string[] args)
    {

        string name;
        Console.WriteLine("What is your name?.");
        Thread.Sleep(200);
        name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + " welcome to my RPG.");
        int health = 100;
        string encounter;
        Thread.Sleep(1000);
        Console.WriteLine("Someone fights you, do you run or attack them.");
        encounter = Console.ReadLine();
        Thread.Sleep(1000);
        Console.WriteLine("You chose to " + encounter);
        if (encounter == "attack")
        {
            Console.WriteLine("You won the fight!");
            health = health - 20;
            Thread.Sleep(200);
            Console.WriteLine("Your current health is ",health);
        }
        else
        {
            Console.WriteLine("You ran away unscathed.");
            Thread.Sleep(200);

        }
        {
            int coins = 40;
            string consumable;
            Console.WriteLine("A mysterious hooded man offers you a RedBull, this will grant you 15 health but costs 20 coins. Your current balance is {0}. (y/n?) " , coins);
            Thread.Sleep(1000);
            consumable = Console.ReadLine();
            Console.WriteLine("You chose ", encounter);
            Thread.Sleep(1000);



            if (consumable == "y") ;
            Console.WriteLine("You drank a RedBull, you feel caffiene and creatine coursing through your veins, granting you 15 health.");
            Thread.Sleep(200);
            health = health + 15;
            coins = coins - 20;

            Console.WriteLine("Your current health is ", + health);
            Thread.Sleep(200);
            Console.WriteLine("Your current balance is " + coins);
            
            





        }
    }



}
