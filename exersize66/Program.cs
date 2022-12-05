/*Задача 66: Задайте значения M и N. Напишите программу,
 которая найдёт сумму натуральных элементов в промежутке от M до N.*/

Console.Clear();
int m = ReadInt("Введите число M = ");
int n = ReadInt("Введите число N = ");

/*string PrintNumber(int start, int end)
{
    if (start==end) return start.ToString();
    return(start + " "+ PrintNumber(start+1, end));
}

Console.WriteLine(PrintNumber(m,n));*/

int SumNum(int start, int end)
{
    if (start==end) return start;
    return end + SumNum(start, end-1);
}
Console.WriteLine($"Сумма чисел от {m} до {n} равна {SumNum(m,n)}");

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}