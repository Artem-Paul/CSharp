// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
int num1 = Convert.ToInt32(Console.ReadLine());


if (num1 > 9999 && num1 < 100000)
{
    int num2 = num1 % 10;
    int num3 = num1 / 10000;
    int num4 = num1 / 10 % 10; 
    int num5 = num1 / 1000 % 10;
    if (num2 == num3 && num4 == num5)
    {
        Console.WriteLine("Это число палиндром"); 
    }
    else 
    {
        Console.WriteLine("Это число не палиндром");
    } 
}
else
{
    Console.WriteLine("Это число не пятизначное");
}

    

