// Принимает на вход координаты точки (X,Y), причём X не равно 0 и Y не равно нулю и
// выдаёт номер четверти плоскости, в которой находится эта точка.

// void Quarters(int x, int y)
// {
//     if (x > 0)
//     {
//         if (y > 0)
//         {
//             Console.WriteLine("I");
//         }
//         else if (y < 0)
//         {
//             Console.WriteLine("IV");
//         }
//     }

//     else if (x < 0)
//         if (y > 0)
//         {
//             Console.WriteLine("II");
//         }
//         else if (y < 0)
//         {
//             Console.WriteLine("III");
//         }
// }

// Quarters(2, 2);
// Quarters(-2, 2);
// Quarters(-2, -2);
// Quarters(2, -2);
// Quarters(2, 0);
// Quarters(0, 2);

void Quarters(int x, int y)
{
    if(x==0||y==0)
    {
        Console.WriteLine("=0");
    }
    else if(x>0 & y>0)
    {
        Console.WriteLine("I");
    }
    else if(x<0 & y>0)
    {
        Console.WriteLine("II");
    }
    else if(x<0 & y<0)
    {
        Console.WriteLine("III");
    }
    else if(x>0 & y<0)
    {
        Console.WriteLine("IV");
    }
}
Quarters(2, 2);
Quarters(-2, 2);
Quarters(-2, -2);
Quarters(2, -2);
Quarters(2, 0);
Quarters(0, 2);
