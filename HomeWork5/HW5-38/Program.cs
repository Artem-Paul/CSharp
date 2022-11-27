// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3 7 22 2 78] -> 76

Console.Write("Введите количество элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
var array = FillArray(num);
Print(array); 

Console.WriteLine();     
Console.WriteLine("Мин элемент массива: " + MinNum(array));
Console.WriteLine("Макс элемент массива: " + MaxNum(array));
Console.Write("Разница между макс и мин элементов: ");
Console.WriteLine(MaxNum(array) - MinNum(array));


int MinNum (int[] array)             // Метод минимальный элемент массива
{    
    int imin = 0;
    for (int i = 0; i < array.Length; i++)
    {  
        if (array[imin] > array[i])
        {
            imin = i;
        }
    }
     return array[imin];             // 
}

int MaxNum (int[] array)             // Метод максимальный элемент массива
{    
    int imax = 0;
    for (int i = 0; i < array.Length; i++)
    {  
        if (array[imax] < array[i])
        {
            imax = i;
        }
    }
     return array[imax];  
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
