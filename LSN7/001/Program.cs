//Задача 46. Задайте двумерный массив размера m на n, заполнеными случайными числами

Console.WriteLine("Введите количество строк: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов: ");
int number2 = Convert.ToInt32(Console.ReadLine());
double[,] arrayTable = new double[number1, number2];
Random random = new Random();  // создаем облако случайных чисел

// var random = new Random().Next();  // создается одно рандомное число

for (int i = 0; i < arrayTable.GetLength(0); i++)
{
    for (int j = 0; j < arrayTable.GetLength(1); j++)
    {
        arrayTable[i,j] = random.Next(-99, 100) / 100.0; 
         Console.Write($"{arrayTable[i,j]} ");
    }
    Console.WriteLine();
    
}
