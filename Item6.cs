using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter y: ");
        int y = int.Parse(Console.ReadLine());

        Console.Write("Enter z: ");
        int z = int.Parse(Console.ReadLine());

        if (z >= x && z <= y)
        {
            Console.WriteLine($"{z} is just within {x} and {y}");
        }
        else
        {
            int diff_x_z = Math.Abs(x - z);
            int diff_z_y = Math.Abs(z - y);

            if (diff_x_z > diff_z_y)
            {
                Console.WriteLine($"{z} is farther from {x}");
            }
            else
            {
                Console.WriteLine($"{z} is farther from {y}");
            }
        }
    }
}