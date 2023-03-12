// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с 
// наименьшей суммой элементов.
// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с 
// наименьшей суммой элементов: 1 строка

int[,] InitArray()
{
    int[,] array = new int[4, 5];
    Random rnd = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
        }
    }
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                System.Console.Write($"{array[i, j]} ");
            }
        }
        System.Console.WriteLine();
    }
}


int FindMinSum(int[,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int min = 0;
        int sum = 0;
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
        min = min + array [0, j];        
        sum = sum + array [i, j];
        }
        if (sum<min)
        {
            min = sum;
            count = i;
        }
        else 
        {
            count = i;
        }
        
    }
    return count;
}

int [,] array = InitArray();
PrintArray(array);
Console.WriteLine();
int result = FindMinSum (array);
Console.Write ($"Наименьшая сумма элементов: {result} строка " );


