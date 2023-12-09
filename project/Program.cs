// Вводятся положительные числа. Определите сумму чисел, делящихся на положительное число a нацело.
// При вводе отрицательного числа закончите работу;

using System;

class work_6_4
{
    static void Main()
    {
        Console.Write("Введите делитель: "); 
        int a = Convert.ToInt32(Console.ReadLine()); 
        int sum = 0; 

        while (true)
        {
            Console.Write("Введите число: "); 
            int n = Convert.ToInt32(Console.ReadLine()); 
            if ( n < 0)
            {
                Console.WriteLine($"Итог: {(sum/a)}"); 
                break; 
            }
            else
            {
                sum += n; 
            }
        }
    }
}

