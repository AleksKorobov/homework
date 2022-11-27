/* Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/

int SumNumbersInNumder(int num)
{int sum = 0;
    while (num > 0)
    {
        sum += num % 10;//прибавляем каждый раз остаток от деления
        num = num/10;
    }
    return sum;
}
Console.WriteLine("Введите целое число:");
int num = int.Parse(Console.ReadLine());
int sum = SumNumbersInNumder(num);