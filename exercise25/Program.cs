﻿/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/


Console.WriteLine("Введите число N: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа N");
int degree = int.Parse(Console.ReadLine());
int result = num;
for (int i = 1; i < degree; i++)
{
    result = (result*num);
}
Console.Write(result);




//Console.Write(Math.Pow(num, degree));
