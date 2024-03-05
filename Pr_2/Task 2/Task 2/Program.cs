using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Введіть довжини трьох сторін трикутника:");

        double side1, side2, side3;
        bool isValidInput;

        do
        {
            Console.Write("Сторона 1: ");
            isValidInput = double.TryParse(Console.ReadLine(), out side1) && side1 > 0;

            if (!isValidInput)
            {
                Console.WriteLine("Некоректне значення. Будь ласка, введіть додатне число.");
            }
        } while (!isValidInput);

        do
        {
            Console.Write("Сторона 2: ");
            isValidInput = double.TryParse(Console.ReadLine(), out side2) && side2 > 0;

            if (!isValidInput)
            {
                Console.WriteLine("Некоректне значення. Будь ласка, введіть додатне число.");
            }
        } while (!isValidInput);

        do
        {
            Console.Write("Сторона 3: ");
            isValidInput = double.TryParse(Console.ReadLine(), out side3) && side3 > 0;

            if (!isValidInput)
            {
                Console.WriteLine("Некоректне значення. Будь ласка, введіть додатне число.");
            }
        } while (!isValidInput);

        if (IsTriangleValid(side1, side2, side3))
        {
            double perimeter = side1 + side2 + side3;

            double semiPerimeter = perimeter / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - side1) * (semiPerimeter - side2) * (semiPerimeter - side3));

            Console.WriteLine($"Периметр трикутника: {perimeter}");
            Console.WriteLine($"Площа трикутника: {area}");

            if (side1 == side2 && side2 == side3)
            {
                Console.WriteLine("Трикутник - рівносторонній.");
            }
            else if (side1 == side2 || side2 == side3 || side1 == side3)
            {
                Console.WriteLine("Трикутник - рівнобедрений.");
            }
            else
            {
                Console.WriteLine("Трикутник - різносторонній.");
            }
        }
        else
        {
            Console.WriteLine("Трикутник з такими сторонами не існує.");
        }
    }

    static bool IsTriangleValid(double side1, double side2, double side3)
    {
        return side1 + side2 > side3 && side1 + side3 > side2 && side2 + side3 > side1;
    }
}
