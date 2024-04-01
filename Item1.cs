using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter years of work: ");
        int yearsOfWork = int.Parse(Console.ReadLine());

        Console.Write("Enter kind of work: ");
        char kindOfWork = char.ToUpper(Console.ReadLine()[0]);

        int salary;

        if (yearsOfWork < 2)
        {
            salary = (kindOfWork == 'B') ? 10000 : 20000;
        }
        else if (yearsOfWork < 5)
        {
            salary = (kindOfWork == 'B') ? 12000 : 40000;
        }
        else
        {
            salary = (kindOfWork == 'B') ? 15000 : 75000;
        }

        Console.WriteLine($"Salary: {salary:N0}");
    }
}