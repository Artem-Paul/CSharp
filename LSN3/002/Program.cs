// Напишите программу которая по заданному номеру четверти показывает диапозон возможных координат точек
// в этой четверти (x и y)


var quater = Convert.ToInt32(Console.ReadLine());

switch(quater)
{
    case 1:
        Console.WriteLine("x > 0 and y > 0");
        break;
    case 2:
        Console.WriteLine("x < 0 and y > 0");
        break;
    case 3:
        Console.WriteLine("x < 0 and y < 0");
        break;
    case 4:
        Console.WriteLine("x > 0 and y < 0");
        break;
    default:
        Console.WriteLine("No");
        break;
}


//  try
// {
// var quarter = Convert.ToInt32(Console.ReadLine());

// switch(quarter)
// {
//     case 1:
//         Console.WriteLine("x > 0 and y > 0");
//         break;
//     case 2:
//         Console.WriteLine("x < 0 and y > 0");
//         break;
//     case 3:
//         Console.WriteLine("x < 0 and y < 0");
//         break;
//     case 4:
//         Console.WriteLine("x > 0 and y < 0");
//         break;
//     default:
//         Console.WriteLine("No");
//         break;
// }
// }
// catch (Expection ex)
// {
//    Console.WriteLine(ex.Message);
// }
