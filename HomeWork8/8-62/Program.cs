// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

var arr = SpiralMatrix(4, 4);
PrintMatrix(arr);

int[,] SpiralMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    int value = 1;
    int i = 0;
    int j = -1;

    while (++j < rows)
    {
        matrix[0, j] = value;
        value++;
    }
    while (++i < colums)
    {
        matrix[i, colums - 1] = value;
        value++;
    }
    while (--j > 0)
    {
        matrix[rows - 1, j - 1] = value;
        value++;
    }
    while (--i > 1)
    {
        matrix[i - 1, 0] = value;
        value++;
    }
    while (j++ < rows - 2)
    {
        matrix[1, j] = value;
        value++;
    }
    while (i++ < colums - 2)
    {
        matrix[i, colums - 2] = value;
        value++;
    }
    matrix[2, 1] = value;

    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            {
                if (matrix[i, j] > 9)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                if (matrix[i, j] <= 9)
                {
                    Console.Write($"0{matrix[i, j]} ");
                }
            }
        }
        Console.WriteLine();
    }
}