//Задача 48. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле
// Amn=m+n. Выведите полученный массив на экран

Console.WriteLine("Введите количество строк: ");
var number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
var number2 = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[number1, number2];
Random random = new Random();

Print(FillArray(array));

int[,] FillArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = i + j;
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