/* Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16*/

int GetNum(string message)
{
    System.Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
void NumberDegree(int num, int degree)
{
    Console.WriteLine(Math.Pow(num, degree));
}
int num = GetNum("Введите число: ");
int degree = GetNum("Введите степень числа");
NumberDegree(num, degree);

//(Math.Pow(num, degree));