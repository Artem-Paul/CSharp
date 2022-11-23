// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

Console.WriteLine("Введите число ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Сумма цифр этого числа : " + GetSum(num1));

int GetSum(int num)
{
    int res = 0;
    int num2 = 0;
    while (num > 0)
    {
        num2 = num % 10;
        num = num / 10;
        res = res + num2;
    }
       return res;
}
