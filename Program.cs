using System;

namespace Homework5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Call Q1_method()
            Console.WriteLine("Q1: Find the largest of two numbers.");
            int maxTwo = Q1_method();
            Console.WriteLine($"The largest number is: {maxTwo}");

            // Call Q2_method()
            Console.WriteLine("\nQ2: Find the largest of four numbers.");
            int maxFour = Q2_method();
            Console.WriteLine($"The largest number among four is: {maxFour}");

            // Call Q3_method()
            Console.WriteLine("\nQ3: Account Creation Process");
            createAccount();
        }

        // Q1: Get 2 integers from keyboard and return the largest one
        static int Q1_method()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            return a > b ? a : b;
        }

        // Q2: Get 4 integers and return the largest one using Q1_method
        static int Q2_method()
        {
            Console.Write("Enter first number: ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int b = int.Parse(Console.ReadLine());

            Console.Write("Enter third number: ");
            int c = int.Parse(Console.ReadLine());

            Console.Write("Enter fourth number: ");
            int d = int.Parse(Console.ReadLine());

            int max1 = Q1_method_helper(a, b);
            int max2 = Q1_method_helper(c, d);
            return Q1_method_helper(max1, max2);
        }

        // Helper method to use Q1 logic within Q2
        static int Q1_method_helper(int a, int b)
        {
            return a > b ? a : b;
        }

        // Q3: Check if birth year makes user 18+
        static bool checkAge(int birth_year)
        {
            int current_year = DateTime.Now.Year;
            int age = current_year - birth_year;
            return age >= 18;
        }

        // Q3: Account creation process
        static void createAccount()
        {
            Console.Write("Enter username: ");
            string username = Console.ReadLine();

            Console.Write("Enter password: ");
            string password1 = Console.ReadLine();

            Console.Write("Re-enter password: ");
            string password2 = Console.ReadLine();

            Console.Write("Enter birth year: ");
            int birthYear = int.Parse(Console.ReadLine());

            if (checkAge(birthYear))
            {
                if (password1 == password2)
                {
                    Console.WriteLine("Account is created successfully");
                }
                else
                {
                    Console.WriteLine("Wrong password");
                }
            }
            else
            {
                Console.WriteLine("Could not create an account");
            }
        }
    }
}

