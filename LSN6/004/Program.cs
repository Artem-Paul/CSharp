// Задача 44. Не используя рекурсию, введите первые N чисел ряда Фибонначи. Первые два числа Фибоначи 0 и 1
// 5 = > 0 1 1 2 3 
PrintFibanachiNum(10);
void PrintFibanachiNum(int count)
{
    int currentNum = 1;
    int currentCount = 2;
    int firstNum = 0;
    int secondNum = 1;
    Console.WriteLine("0, 1, ");
    while(currentCount != count)
    {
        currentNum = firstNum + secondNum;
        firstNum = secondNum;
        secondNum = currentNum;
        Console.Write($"{currentNum}, ");
        currentCount++;
    }

}