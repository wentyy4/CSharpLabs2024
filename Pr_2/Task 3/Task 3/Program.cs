using System;

class Program
{
    static void Main()
    {
        const int length = 10 + 16;

        double[] X = new double[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            X[i] = random.NextDouble() * 1000; 
        }

        double min = X[0];
        double max = X[0];

        for (int i = 1; i < length; i++)
        {
            if (X[i] < min)
            {
                min = X[i];
            }

            if (X[i] > max)
            {
                max = X[i];
            }
        }

        Console.WriteLine("Масив X:");
        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"X[{i}] = {X[i]}");
        }
        Console.WriteLine($"Мінімальне значення: {min}");
        Console.WriteLine($"Максимальне значення: {max}");
    }
}
