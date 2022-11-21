// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.WriteLine("Введите значение x1: ");
var x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение y1: ");
var y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение z1: ");
var z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение x2: ");
var x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение y2: ");
var y2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение z2: ");
var z2 = Convert.ToInt32(Console.ReadLine());

var result = Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2) + Math.Pow((z1-z2),2) );   

Console.WriteLine (result);