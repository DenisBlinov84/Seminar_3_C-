// Принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
// 5 -> 1,4,9,16,25
// 2 -> 1,4

// void Squares(int num)
// {
//     int i = 1;

//     while (num >= i)
//     {
//         Console.WriteLine(Math.Pow(i, 2));
//         i++;
//     }
// }
// Squares(5);

void Squares(int n)
{
    double[] nums = new double[n];
    int index = 0;
    Console.Write($"{n} -> ");

    while (index < n)
    {
        nums[index] = Math.Pow((index + 1), 2);
        Console.Write($"{nums[index]}, ");
        index += 1;
    }
    Console.WriteLine();
}

Squares(6);
Squares(2);
Squares(11);
