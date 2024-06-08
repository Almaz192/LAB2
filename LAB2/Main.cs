using System;

class Program
{
    static void Main(string[] args)
    {

        double a, b, c;

        // Input coefficients with text prompts
        while (true)
        {
            Console.Write("Enter coefficient a: ");
            if (double.TryParse(Console.ReadLine(), out a))
                break;
            else
                Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        while (true)
        {
            Console.Write("Enter coefficient b: ");
            if (double.TryParse(Console.ReadLine(), out b))
                break;
            else
                Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        while (true)
        {
            Console.Write("Enter coefficient c: ");
            if (double.TryParse(Console.ReadLine(), out c))
                break;
            else
                Console.WriteLine("Invalid input. Please enter a valid number.");
        }

        try
        {
            double discriminant = b * b - 4 * a * c;

            if (discriminant < 0)
            {
                throw new Exception("The equation has no real roots.");
            }
            else
            {
                double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"The equation has two real roots: {root1} and {root2}");
            }
        }

        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}
