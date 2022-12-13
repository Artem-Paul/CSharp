// Задача 32. Напишите программу замены элементов массива :
// положиельные элементы замените на соответсвующие отрицательные , и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

var array = FillArray(12);
Print(array);
Console.WriteLine();
ReplaceArray(array);
Print(array);

void ReplaceArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}

int[] FillArray(int length)           // метод заполнить массив
{
    int [] array = new int [length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(-9,9);
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
