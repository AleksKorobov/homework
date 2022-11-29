/* Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
 k1 * x + b1 = k2 * x + b2
 k1 * x - k2 * x  = b2- b1
 (k1 - k2 )* x = b2- b1
 x=(b2- b1)/(k1 - k2)
 (k1 - k2) - не должно равняться 0*/

double GetNum(string message)
{
    Console.WriteLine(message);
    return double.Parse(Console.ReadLine());
}

double b1 = GetNum("Введите b1:");
double k1 = GetNum("Введите k1:");
double b2 = GetNum("Введите b2:");
double k2 = GetNum("Введите k2:");

double x = (b2 - b1) / (k1 - k2);
double y1 = k1 * x + b1;
double y2 = k2 * x + b2;

if (k1 != k2)
{
    Console.WriteLine($"Точка перечения двух прямых будет:({(x)};{(y1)})");
}
else
{
    Console.WriteLine("Прямые параллельны");
}