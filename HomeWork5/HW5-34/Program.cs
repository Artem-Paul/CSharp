// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("Введите количество элементов в массиве: ");
int num = Convert.ToInt32(Console.ReadLine());
var array = FillArray(num);
Print(array);      
Console.WriteLine();
Console.Write("Количество четных элементов в массиве: " + evenNum(array));

int evenNum(int [] array)          // метод нахождения количества четных чисел
{
    int even = 0;
    foreach(int item in array)    // item элемент массива, а цикл foreach, это цикл для перебора элементов 
                                  //какой  то коллекции
    {
        if(item % 2 == 0)         // так определяем положительное значение
        {
            even = even + 1;
        }
    }
    return even;
}




int[] FillArray(int length)           // метод заполнить массив
{
    int [] array = new int [length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(100,1000);
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