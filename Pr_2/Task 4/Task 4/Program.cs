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
            X[i] = random.NextDouble() * 2000 - 1000;
        }

        Console.Write("Введіть число M: ");
        double M = double.Parse(Console.ReadLine());

        double[] Y = new double[length];
        int yIndex = 0;

        for (int i = 0; i < length; i++)
        {
            if (Math.Abs(X[i]) > M)
            {
                Y[yIndex] = X[i];
                yIndex++;
            }
        }

        Console.WriteLine($"Число M: {M}");
        Console.WriteLine("Масив X:");
        PrintArray(X);
        Console.WriteLine("Масив Y (елементи з масиву X, які більше за модулем числа M):");
        PrintArray(Y, yIndex);
    }

    static void PrintArray(double[] array, int length = -1)
    {
        if (length == -1)
        {
            length = array.Length;
        }

        for (int i = 0; i < length; i++)
        {
            Console.WriteLine($"X[{i}] = {array[i]}");
        }
    }
}
