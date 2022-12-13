// Задача 39, напишите программу которая перевернет одномерный массив

Console.Write("Введите количество элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
var array = FillArray(num);
Print(array);
Console.WriteLine();

Print(ReverseArray(array));


int[] ReverseArray(int[] array)
{
    int length = array.Length;
    int[] result = new int[length];
    for (int i = length - 1; i >= 0; i--)
    {
        result[length-1-i] = array[i];
    }

    return result;
}

int[] FillArray(int length)           // метод заполнить массив
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

void Print(int[] array)              // метод напечатать массив
{
    foreach (var item in array)
    {
        Console.Write($"{item}, ");
    }
}