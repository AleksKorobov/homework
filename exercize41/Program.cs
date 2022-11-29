/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/
Console.WriteLine("Напишите количество чисел к вводу: ");
int M = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < M; i++)
{
    Console.WriteLine($"Введите число {i + 1}: "); 
    int Numbers = int.Parse(Console.ReadLine());
    if (Numbers > 0)
        count += 1;
}
Console.WriteLine($"Количество положительных чисел: {count}");
