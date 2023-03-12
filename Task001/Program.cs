int[,] InitArray()
{
    int[,] array = new int[4, 8];
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

void ArrangeNumbers(int[,] array)
{
    

    int change = 0; // переменная для временной записи
    for (int i = 0; i < array.GetLength(0); i++) //цикл на вывод столбцов матрицы
    {

        for (int j = 0; j < array.GetLength(1); j++) // цикл на вывод строк матрицы
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if(array[i,j]<array[i,k])
                {
                    change = array[i,j];
                    array[i,j] = array[i,k];
                    array[i,k] = change;
                }
            }
           
        }
    }

}

int[,] array = InitArray();
PrintArray(array);
ArrangeNumbers(array);
System.Console.WriteLine();
PrintArray(array);

