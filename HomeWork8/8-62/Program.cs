// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

var arr = FillMatrix(4, 4);
PrintMatrix(arr);

int[,] FillMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    int k = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = k + 1;
            k++;
        }
    }

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