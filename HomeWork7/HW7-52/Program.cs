// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в 
// каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int[,] arr = new int[3, 4];
Random random = new Random();
Print(FillArray(arr));

AverageColumn(arr);

void AverageColumn(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++) 
    {   
        double sumColumn = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sumColumn += arr[i, j];
        }
        double result = sumColumn / arr.GetLength(0);
        Console.WriteLine($"Среднее арифметичесое столбца {j} = {result}");
    }
 
}

int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = random.Next(0, 100);
        }
    }
    return arr;
}

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}