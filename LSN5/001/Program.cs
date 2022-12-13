// Задача 31. Задайте массив из 12 элементов, заполненый случайными числами из промежутка [-9,9]. Найдите 
// сумму отрацательных и положительных элементов массива. Например в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6]

var array = FillArray(10);
Print(array);      // метод ввыдоа массива (47я строка)
Console.WriteLine();
Console.Write($"Сумма положительных элементов: {SumPol(array)} Сумма отрицательных элементов: {SumOtr(array)}");

int SumPol(int [] array)          // метода слу нахождения суммы положительных элементов
{
    int sum = 0;
    foreach(int item in array)  // item элемент массива, а цикл foreach цикл для перебора элементов какой 
                                                //то коллекции
    {
        if(item >= 0)         // так определяем положительное значение
        {
            sum += item;
        }
    }
    return sum;
}

int SumOtr(int [] array)          
{
        int sum = 0;
    foreach(int item in array)      // for (int item = 0; i < array.length; i++)
    {
        if(item <= 0)               // if(array [i] >= 0)
        {
            sum += item;            // sum += array[i];
        }
    }
    return sum;
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