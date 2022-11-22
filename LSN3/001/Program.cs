// Задача №17

var x = Convert.ToInt32(Console.ReadLine());
var y = Convert.ToInt32(Console.ReadLine());

if (x > 0 && y > 0)
{
    Console.WriteLine('1');
}
else if (x < 0 && y > 0)
{
    Console.WriteLine('2');
}
else if (x < 0 && y < 0)
{
    Console.WriteLine('3');
}
else  
{
    Console.WriteLine('4');
}


