// Задача 35. Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива,
// значения которых лежат в отрезке [10, 99].
// Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123 
// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0

var array = FillArray(123);
Print(array);      // метод ввыдоа массива (47я строка)
Console.WriteLine();
Console.WriteLine(GetCount(array));

int GetCount(int[] array)
{
    int count = 0;
    foreach(var item in array)
    {
        if (item >= 10 && item <=99)
        {
            count++;
        }
    }
    return count;
}

int[] FillArray(int length)           // метод заполнить массив
{
    int [] array = new int [length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0,1000);
    }
    return array; 
}

void Print (int[]array)              // метод напечатать массив
{
    foreach(var item in array)
    {
        Console.Write($"{item}, ");
    }
}
