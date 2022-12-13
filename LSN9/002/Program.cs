// Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

System.Console.WriteLine(GetSum(1124765));

long GetSum(long num)
{
    if (num == 0)
    {
        return 0;
    }
    return (num % 10 + GetSum(num / 10));
}
