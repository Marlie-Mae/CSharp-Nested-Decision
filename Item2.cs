using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter current pocket money: ");
        if (!int.TryParse(Console.ReadLine(), out int pocketMoney) || pocketMoney < 0)
        {
            Console.WriteLine("Stop lying, tell me what's in your pocket!");
            return;
        }

        Console.WriteLine(pocketMoney);

        if (pocketMoney % 10 == 7)
        {
            Console.WriteLine("Such lucky money!");
        }
        else
        {
            Console.WriteLine("Just normal money.");
        }
    }
}