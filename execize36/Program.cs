/* Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

void FiilArrayRandomeNum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int CountEvenNumbers(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i=i+2)
    {
        sum = sum + array[i];
    }
    return sum;
}

int[] a = new int[4];

FiilArrayRandomeNum(a);
PrintArray(a);
Console.WriteLine(CountEvenNumbers(a));
