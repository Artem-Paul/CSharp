// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int[,] arr = new int[6, 10];
Random random = new Random();
Print(FillArray(arr));

// Console.Write("Введите номер строки: ");
// int numi = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите номер столбца: ");
// int numj = Convert.ToInt32(Console.ReadLine());

SearchNum(Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));

int[,] SearchNum(int numi, int numj)
{
    if (numi >= arr.GetLength(0))
    {
        Console.WriteLine("Строка отсутвует в массиве!");
    }
    if (numj >= arr.GetLength(1))
    {
        Console.WriteLine("Столбец отсутвует в массиве!");
    }
    else
    {
        Console.WriteLine($"Число на этой позиции: {arr[numi, numj]}");
    }

    return arr;
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