// Напишите программу, которая принимает на вход число N и выдает таблицу квадратов чисел 
// от 1 до N

Console.WriteLine("Введите число: ");
var num = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= num; i++)
{
    Console.WriteLine(Math.Pow(i,2));
}