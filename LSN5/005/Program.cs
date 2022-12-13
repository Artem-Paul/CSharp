// Задача 37. Найдите произведение пар чисел в одномерном масиве.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.
// результат запишите в новом массиве.
// [1 2 3 4 5] ->  5 8 3
// [6 7 3 6] -> 36 21

var array = FillArray(5);
Print(array);       
Console.WriteLine();
int[] newArr = MyltiplyPair(array);
Print(newArr);

int[] MyltiplyPair(int[] array)
{
    int newLength = 0;
    if (array.Length % 2 == 0) 
    {
        newLength = array.Length / 2;
    }
    else
    {
        newLength = array.Length / 2 + 1;
    }
    int [] result = new int[newLength];

    for (int i = 0; i < newLength; i++)
    {
        if (i == array.Length - 1 - i)
        {
            result[i] = array[i];
        }
        else
        {
            result[i] = array[i] * array[array.Length - 1 - i];
        }
        
    }
    return result;
    
}

int[] FillArray(int length)           // метод заполнить массив
{
    int [] array = new int [length];
    for(int i = 0; i < length; i++)
    {
        array[i] = new Random().Next(0,10);
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
