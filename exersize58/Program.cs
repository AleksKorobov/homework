/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.*/

Console.Clear();
int rows = ReadInt("Введите количество строк и столбцов: ");
int columns = rows;
int[,] fistArray = new int[rows, columns];
int[,] secondArray = new int[rows, columns];
int[,] resultArray = new int[rows, columns];

FillArrayRandom(fistArray);
PrintArray(fistArray);
Console.WriteLine();
FillArrayRandom(secondArray);
PrintArray(secondArray);
Console.WriteLine();
MultiArray(fistArray, secondArray, resultArray);
Console.WriteLine("Произведение матриц:");

void MultiArray(int[,] fistArray, int[,] secondArray, int[,] resultArray)
{
    for (int i = 0; i < resultArray.GetLength(0); i++)
    {
        for (int j = 0; j < resultArray.GetLength(1); j++)
        {
         resultArray[i, j] = fistArray[i, j] * secondArray[i, j];
        }
    }
}

PrintArray(resultArray);



int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine()!);
}

void FillArrayRandom(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}