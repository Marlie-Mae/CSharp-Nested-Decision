using System;

class MainClass {
    static public void Main()
    {
        Console.Write("Choose the programming language you like best: ");
        if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 5)
        {
            return;
        }

        switch (choice)
        {
            case 1:
                Console.WriteLine("You like C best");
                break;
            case 2:
                Console.WriteLine("You like C++ best");
                break;
            case 3:
                Console.WriteLine("You like Java best");
                break;
            case 4:
                Console.WriteLine("You like C# best");
                break;
            case 5:
                Console.WriteLine("You like Python best");
                Console.Write("Enter type of development: ");
                char developmentType = char.ToUpper(Console.ReadLine()[0]);

                switch (developmentType)
                {
                    case 'A':
                        Console.WriteLine("Web");
                        break;
                    case 'B':
                        Console.WriteLine("Data Analytics");
                        break;
                    case 'C':
                        Console.WriteLine("Backend");
                        Console.Write("Do you know any frameworks? ");
                        char knowFrameworks = char.ToUpper(Console.ReadLine()[0]);
                        if (knowFrameworks == 'Y')
                        {
                            Console.Write("Wow, you're good!");
                        }
                        break;
                }
                break;
        }
    }
}