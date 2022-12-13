// Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10

                // метод, нужен что бы не писать по нескольку раз, к примеру console.writeline

Console.WriteLine("Введите число A");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Сумма чисел от 1 до {num1}: " + GetSum(num1));

int GetSum(int num)
{
    int sum = 0;
    for(int i = 1; i <= num; i++)
    {
        sum += i;
    }
    return sum;
}
