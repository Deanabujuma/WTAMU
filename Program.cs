namespace Homework2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Code for Q1: Grade to GPA conversion

            Console.WriteLine("Enter a letter grade (A, B, C, D, F): ");
            char grade = Convert.ToChar(Console.ReadLine().ToUpper());

            if (grade == 'A')
            {
                Console.WriteLine("GPA: 4");
            }
            else if (grade == 'B')
            {
                Console.WriteLine("GPA: 3");
            }
            else if (grade == 'C')
            {
                Console.WriteLine("GPA: 2");
            }
            else if (grade == 'D')
            {
                Console.WriteLine("GPA: 1");
            }
            else if (grade == 'F')
            {
                Console.WriteLine("GPA: 0");
            }
            else
            {
                Console.WriteLine("Wrong Letter Grade!");
            }

            // Code for Q2: Find the smallest number

            Console.WriteLine("\nEnter three numbers to find the smallest:");

            Console.Write("Enter first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int smallest = num1;

            if (num2 < smallest)
            {
                smallest = num2;
            }

            if (num3 < smallest)
            {
                smallest = num3;
            }

            Console.WriteLine("\nThe smallest number is: " + smallest);

            // Code for Bonus Question: Leap year check

            Console.WriteLine("\nEnter a year to check if it's a leap year:");
            int year = Convert.ToInt32(Console.ReadLine());

            if ((year % 4 == 0 && year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine(year + " is a leap year.");
            }
            else
            {
                Console.WriteLine(year + " is not a leap year.");
            }
        }
    }
}
