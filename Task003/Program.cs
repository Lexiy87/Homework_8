// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int [,] InitArray()
{
    int [,] array = new int [2,2];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array [i,j] = rnd.Next(0,10);
        }
    }
    return array;
}

void PrintArray (int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength (1); j++)
        {
            System.Console.Write($" {array[i,j]}");
        }
        System.Console.WriteLine();
    }
}

int [,] FindResultMatrix (int [,] arrayOne, int [,] arrayTwo)
{
    int [,] result = new int [2,2];

    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            for (int k = 0; k < result.GetLength(1); k++)
            {
                result[i,j] += arrayOne[i,k] * arrayTwo [k,j];
            }
        }
    }
    return result;
}

int [,] arrayOne = InitArray();
int [,] arrayTwo = InitArray();
PrintArray(arrayOne);
System.Console.WriteLine();
PrintArray(arrayTwo);
System.Console.WriteLine();
int [,] result = FindResultMatrix(arrayOne,arrayTwo);
PrintArray(result);
