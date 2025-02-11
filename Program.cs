namespace Homework4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Q1_method
            Q1_method(12, 7);

            // Call Q2_method
            Q2_method(5, "left");
            Q2_method(5, "right");
        }

        // Q1_method: This method takes two numbers and returns the largest one.
        static void Q1_method(int num1, int num2)
        {
            int largest = (num1 > num2) ? num1 : num2;
            Console.WriteLine($"The largest number between {num1} and {num2} is: {largest}");
        }

        // Q2_method: This method prints a triangle based on the shape and N value.
        static void Q2_method(int N, string shape)
        {
            // Print the shape and N value
            Console.WriteLine($"N = {N}, Shape = {shape}");

            // Check the shape type and print the corresponding triangle pattern
            if (shape.ToLower() == "left")
            {
                // Left triangle pattern
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else if (shape.ToLower() == "right")
            {
                // Right triangle pattern
                for (int i = 1; i <= N; i++)
                {
                    // Print spaces before stars
                    for (int j = 1; j <= N - i; j++)
                    {
                        Console.Write(" ");
                    }
                    // Print stars
                    for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid shape input.");
            }
        }
    }
}
