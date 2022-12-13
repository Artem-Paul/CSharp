// Задача 69: Напишите программу, которая на вход принимает два числа A и B, 
//и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

System.Console.WriteLine(Pow(2, 10));

int Pow(int num, int rang)
{
    if (rang == 0)
    {
        return 1;
    }
    if (rang == 1)
    {
        return num;
    }
    return (num * Pow(num, --rang));
}