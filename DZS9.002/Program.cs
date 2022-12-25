// Задача 2: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int Prompt(string message)
{
    Console.Write($"{message} > ");
    string input = Console.ReadLine();
    return Convert.ToInt32(input);
}

int Sum(int n, int m)
{
    if (n < m)
    {
        return 0;
    }
    return Sum(n - 1, m) + n;
}

int n = Prompt("Введите N");
int m = Prompt("Введите M");

Console.WriteLine(Sum(n, m));
