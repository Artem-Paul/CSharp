// Задача 33. Задайте массив. Напишите программу, напишите программу, которая определяет присутвует 
// ли заданное число в массиве
// 4; массив [6,7,19,345,3] -> нет
// -3; массив [6,7,19,345,3] -> да

var array = FillArray(15);
Print(array);
Console.WriteLine("Введите число из массива: ");
var UserNum = Convert.ToInt32(Console.ReadLine());

if(FindNum(array, UserNum))
{
    System.Console.WriteLine("Yes");
}
else
{
    System.Console.WriteLine("No");
}

bool FindNum(int[] arr, int num)
{
    foreach (var item in arr)
    {
        if(item == num)                     // true false переменная bool
        {
            return true;
        }
    }
    return false;
}    

int[] FillArray(int length)           // метод заполнить массив
{
    int [] array = new int [length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(1,7);
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
