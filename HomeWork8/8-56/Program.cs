// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

var matrix = FillMatrix(4, 4);
int[] sumRowArr = new int[matrix.GetLength(0)];
PrintMatrix(matrix);                                  // В этом 8м дз, данная задача оказалось самой сложной. 
SumRows(matrix);                                      // Не знаю почему, но возникла сложность с поиском наименьшей      
// MinRow(sumRowArr);                                 // суммы строки при помощи дополнительного метода, я пытался              
                                                      // создать одномерный массив, но так ничего и
int[,] SumRows(int[,] matrix)                         // заработало. Где можно почитать о методах доп. инфу?
{
    int iMin = 0;
    int sumMin = 0;
    // int[] sumRow = new int[matrix.GetLength(0)];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int sumRow = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sumRow += matrix[i, j];
        }
        if (i == 0)
        {
            sumMin = sumRow;
            iMin = i;
        }
        if (sumMin > sumRow)
        {
            sumMin = sumRow;
            iMin = i;
        }

        Console.WriteLine($"Сумма элементов строки {i}= {sumRow}");
    }
    System.Console.WriteLine($"Наименьшая сумма элементов на строке: {iMin}");

    return matrix;
}

// int MinRow(int[] sumRowArr)
// {
//     int result = sumRowArr[0];
//     int iMin = 0;
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         if (sumRowArr[iMin] > sumRowArr[i])
//         {
//             result = sumRowArr[iMin];
//             iMin = i;
//         }
//     }
//     Console.WriteLine($"Наименьшая сумма на строке {iMin}");

//     return iMin;
// }

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


