/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/
void FiilArrayRandomeNum(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0, 100);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int MaxNumberArray(int[] array)
{
    int max = array[1];;
    for (int i = 0; i < array.Length; i++)
    {
        if(max < array[i]) max= array[i];
    }
    return max;
}
int MinNumberArray(int[] array)
{
    int min = array[1];
    for (int i = 0; i < array.Length; i++)
    {
        if(min > array[i]) min= array[i];
    }
    return min;
}

int[] a = new int[10];
FiilArrayRandomeNum(a);
PrintArray(a);
Console.WriteLine();
Console.WriteLine((MaxNumberArray(a))-(MinNumberArray(a)));

