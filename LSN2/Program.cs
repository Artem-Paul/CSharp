// Console.WriteLine("Введите первое число");
// int num1 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int num2 = Convert.ToInt32(Console.ReadLine());
// if (num1 % num2 == 0 )
// {
//     Console.WriteLine("кратно");
// }
// else
// {
//     Console.WriteLine($"Остаток {num1 % num2}");
// }


// Console.WriteLine("Введите первое число");
// int num = Convert.ToInt32(Console.ReadLine());
// if (num % 7 == 0 && num % 23 == 0)
// {
//     Console.WriteLine("кратное");
// }
// else
// {
//      Console.WriteLine("не кратно");
// }




Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 * num1 == num2 || num2 * num2 == num1)
{
    Console.WriteLine("является квадратом");
}
else 
{
    Console.WriteLine("не является");
}
