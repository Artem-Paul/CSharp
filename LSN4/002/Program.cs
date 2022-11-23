// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

Console.Write("Введите любое число: ");
var num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Количество цифр в числе: " + GetNum(num1));

int GetNum(int num)

{
    int res = 0;
    while (num > 0)
    {
        num /= 10; 
        res++;    
    }
    return res;
}