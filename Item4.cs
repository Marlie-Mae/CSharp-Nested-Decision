using System;

class MainClass {

    static public void Main()
    {
        int total = 10;
        
        // Hey there, start typing your C# code here...

          Console.Write("Enter an integer: ");
        if (!int.TryParse(Console.ReadLine(), out int num))
        {
            
            return;
        }

        if (num > 0)
        {
            if (num % 2 == 0)
            {
                total += num * num;
            }
            else
            {
                total += num * num * num;
            }
        }
        else if (num < 0)
        {
            Console.Write("Enter another integer: ");
            if (!int.TryParse(Console.ReadLine(), out int exponent))
            {
            
                return;
            }
            total += (int)Math.Pow(num, exponent);
        }
        else
        {
            Console.WriteLine("Nothing happened.");
            return;
        }

        Console.WriteLine(total);
    }
}