using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        if (IsVowel(name[name.Length - 1]))
        {
            Console.Write("Enter age: ");
            int age;
            if (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid age input.");
                return;
            }

            if (age % 2 == 0)
            {
                Console.WriteLine("Wow, you're special!");
            }
            else
            {
                Console.Write("Enter birth year: ");
                int birthYear;
                if (!int.TryParse(Console.ReadLine(), out birthYear))
                {
                    Console.WriteLine("Invalid birth year input.");
                    return;
                }

                if (birthYear % 2 == 0)
                {
                    Console.WriteLine("Oh, you're still special!");
                }
                else
                {
                    Console.WriteLine("You will be special next year.");
                }
            }
        }
        else
        {
            Console.WriteLine("You're awesome!");
        }
    }

    static bool IsVowel(char c)
    {
        return "AEIOUaeiou".IndexOf(c) != -1;
    }
}