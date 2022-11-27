/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/


void NumberDegree(int num, int degree)
{
    Console.WriteLine(Math.Pow(num, degree));
}

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.WriteLine("Введите степень числа");
int degree = int.Parse(Console.ReadLine());

NumberDegree(num, degree);


//Console.Write(Math.Pow(num, degree)