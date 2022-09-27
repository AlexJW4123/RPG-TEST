using System;
using System.Xml.Xsl;

public class Program
{
    public static void Main(string[] args)
    {
       
        string name;
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        Console.WriteLine("Hello, " + name + " welcome to my RPG");

        int health = 100;
        string encounter;
        Console.WriteLine("Someone fights you, do you run or attack them");
        encounter = Console.ReadLine();
        Console.WriteLine("You chose to " + encounter);
        if (encounter == "attack")
        {
            Console.WriteLine("You won the fight!");
            health = health - 20;
            Console.WriteLine(health);
        }
        else
        {
            Console.WriteLine("You ran away");
        }

    }
    

   
}
