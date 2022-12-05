// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл
// пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел: ");
var countNum = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите эти числа: ");
var array = FillArray(countNum);
Print(array);
Console.Write($"Количество чисел больше 0: {positivNum(array)}");

int positivNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0)
        {
            count += 1;
        }
    }

    return count;
}

int[] FillArray(int length)
{
    int[] array = new int[length];
    for (int i = 0; i < length; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}

void Print(int[] array)
{
    foreach (var item in array)
    {
        Console.Write($"{item}, ");
    }
}
