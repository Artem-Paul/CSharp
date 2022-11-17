Console.WriteLine("Введите число 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число 3: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int max = num1;

if (num1 < num2) max = num2;
if (num1 < num3) max = num3;

Console.WriteLine($"Максимальное число: {max} ");

