/* Задача 64: Задайте значение N. Напишите программу, которая выведет все 
натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.*/

Console.Clear();
int n = ReadInt("Введите число N = ");
int m = 1;
NumToLow(n, m);


void NumToLow(int n, int m)
{
    if (m > n)
    {
        return;
    }
    else
    {
        NumToLow(n, m + 1);
        Console.Write(m + " ");
    }
}

int ReadInt(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}