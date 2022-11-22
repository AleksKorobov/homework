// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.WriteLine("Введите число: ");
int x = int.Parse(Console.ReadLine());
int num = 0;
while(num<=x-2) 
{
    num = num+2;
    Console.WriteLine(num);
}
