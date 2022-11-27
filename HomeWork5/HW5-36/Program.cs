// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.Write("Введите количество элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
var array = FillArray(num);
Print(array);      
Console.WriteLine();
Console.Write("Сумма элементов, стоящих на нечетных позициях: " + GetSumOdd(array));

int GetSumOdd(int[] array)
{    
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {  
        if (i % 2 != 0)
        {
            sum = sum + array[i];
        }
    }
     return sum;             // return выводит зачение которое получил метод
}



int[] FillArray(int length)           // метод заполнить массив
{
    int [] array = new int [length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0,101);
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

