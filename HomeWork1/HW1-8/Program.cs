Console.WriteLine("Введите число N: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int i = 1;
Console.WriteLine($"Все четные числа от 1 до {num1}: ");

while (i <= num1)

{
    if (i % 2 == 0)
    Console.WriteLine(i);
    i++;
}






