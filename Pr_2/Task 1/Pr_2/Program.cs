using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть три цілих числа:");

        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());
        int num3 = Convert.ToInt32(Console.ReadLine());

        if (IsInRange(num1))
        {
            Console.WriteLine($"{num1} належить інтервалу [1, 10^16]");
        }
        if (IsInRange(num2))
        {
            Console.WriteLine($"{num2} належить інтервалу [1, 10^16]");
        }
        if (IsInRange(num3))
        {
            Console.WriteLine($"{num3} належить інтервалу [1, 10^16]");
        }
    }

    static bool IsInRange(int num)
    {
        return num >= 1 && num <= Math.Pow(10, 16);
    }
}
