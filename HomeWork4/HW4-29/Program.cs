// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]


int[] array = new int[8];
// PrintArray(array);
Console.WriteLine("Введите количество элементов в массиве, например 8: ");
int num = Convert.ToInt32(Console.ReadLine());

var arr = FillArray(num);       //почему когда вместо var прописываешь int, 
                               //вылетает "Не удается неявно преобразовать тип "int[]" в "int""
PrintArray(arr);

int[] FillArray(int length)
{
    int[] result = new int[length];
    for(int i =0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 101);
    }
    return result;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}
