// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

var matrix = FillMatrix(4, 4);
PrintMatrix(matrix);
SumRows(matrix);

int[,] SumRows(int[,] matrix)
{
    int[] sumRowArr = new int[matrix.GetLength(0)];
    int indexMinSum = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        int minSum = 0;        
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
            sumRowArr[i] = sumRow;
            if (sumRowArr[i] < sumRow)
            {
                minSum = sumRowArr[i];
                indexMinSum = i;
            }
        }
        Console.WriteLine($"Сумма элементов строки {i}= {sumRow}");
    }
    Console.WriteLine($"Наименьшая сумма на строке {indexMinSum}");

    return matrix;
}

int MinRow (int[] sumRowArr)             // метод минимальный элемент массива
{    
    int imin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {  
        if (array[imin] > array[i])
        {
            imin = i;
        }
    }
     return array[imin];             // return выводит зачение которое получил метод
}

int[,] FillMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
}


