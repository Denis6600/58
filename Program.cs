//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
//2 4 | 3 4
//3 2 | 3 3
//Результирующая матрица будет:
//18 20
//15 18

void GetArray(int[,] array, int min, int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void GetArray2(int[,] array2, int min, int max)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            array2[i, j] = new Random().Next(min, max + 1);
        }
    }
}

void PrintArray2(int[,] array2)
{
    for (int i = 0; i < array2.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            Console.Write(array2[i, j] + " ");
        }
        Console.WriteLine();
    }
}

void MultArray(int[,]array, int[,]array2, int[,]mult)
{
    int Summ = 0;
    for (int i = 0; i < mult.GetLength(0); i++)
    {
        for (int j = 0; j < mult.GetLength(1); j++)
        {
            for (int k = 0; k < mult.GetLength(1); k++)
            {
                mult[i,j] += array[i,k] * array2[k,j];
            }
            
        }
    }
    
}



Console.Clear();
int[,] array = new int[2, 2];
int[,] array2 = new int[2, 2];
int[,] mult = new int[2, 2];
GetArray(array, 1, 3);
GetArray2(array2, 1, 3);
PrintArray(array);
Console.WriteLine(); 
PrintArray2(array2);
Console.WriteLine(); 

MultArray(array, array2, mult);
Console.WriteLine($"Произведение первой и второй матриц:");
PrintArray(mult);
