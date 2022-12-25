// Задача 1: Задайте значения M и N. Напишите программу, 
// которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    Console.Write($"{message} > ");
    string input = Console.ReadLine();
    return Convert.ToInt32(input);
}

void PrintEven(int n, int m)
{
    if (n < m)
    {
        return;
    }
    PrintEven(n - 1, m);
    if (n % 2 == 0)
    {
        Console.Write($"{n} ");
    }
}

int n = Prompt("Введите N");
int m = Prompt("Введите M");

PrintEven(n, m);