// Программа для работы с числами с различными возможностями
Main ();

void Main ()
{
    bool isWorking = true;

    while (isWorking)
    {
        Console.WriteLine ("Input task");

        string task = Console.ReadLine ();

        switch (task)
        {
            case "exit": isWorking = false; break;
            case "t1": Task1 (); break;
            case "t3": Task3 (); break;
            default:
                break;
        }
    }
}

// Программа, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

void Task1()
{
    int number1 = ReadInt("first number");
    int number2 = ReadInt("second number");

    if (IsMoreThan(number1, number2))
    {
        Console.WriteLine($"{number1} > {number2}");
    }
    else if (IsMoreThan(number2, number1))
    {
        Console.WriteLine($"{number2} > {number1}");
    }
    else
    {
        Console.WriteLine($"{number1} = {number2}");
    }
}

int ReadInt(string argument)
{
    int number;

    Console.Write($"Input {argument}: ");

    while (!int.TryParse(Console.ReadLine(), out number))
    {
        Console.WriteLine("It's not a integer number!");
        Console.Write("Try again: ");
    }

    return number;
}

bool IsMoreThan(int number1, int number2)
{
    return number1 > number2;
}

// Программа, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// Программа, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

void Task3()
{
    if (IsEven (ReadInt ("Number")))
    {
        Console.WriteLine ("Yes");
    }
    else
    {
        Console.WriteLine ("No");
    }
}

bool IsEven (int number)
{
    return number % 2 == 0;
}

// Программа, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.