// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

var arr = FillMatrix(3, 3);
var arrTwo = FillMatrix(3, 3);

PrintMatrix(arr);
System.Console.WriteLine();
PrintMatrix(arrTwo);
System.Console.WriteLine("Результирующая матрица:");

int[,] multiMatrix = MultiMatrix(arr, arrTwo);
PrintMatrix(multiMatrix);


int[,] MultiMatrix(int[,] arr, int[,] arrTwo)
{
    int[,] multiMatrix = new int[arr.GetLength(0), arrTwo.GetLength(1)];
    if (arr.GetLength(1) == arrTwo.GetLength(0))
    {
        for (int i = 0; i < multiMatrix.GetLength(0); i++)
        {
            for (int j = 0; j < multiMatrix.GetLength(1); j++)
            {
                multiMatrix[i, j] = 0;
                for (int k = 0; k < arr.GetLength(1); k++)
                {
                    multiMatrix[i, j] += arr[i, k] * arrTwo[k, j];
                }
            }
        }
    }
    else
    {
        System.Console.WriteLine("Произведение данных матриц не возможно");
    }

    return multiMatrix;
}


int[,] FillMatrix(int rows, int colums)
{
    int[,] matrix = new int[rows, colums];
    Random rnd = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(1, 6);
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
            Console.Write($"{matrix[i, j]}, ");
        }
        Console.WriteLine();
    }
}

