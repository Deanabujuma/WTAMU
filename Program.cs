namespace Homework3;
class Program
{
    static void Main(string[] args)
    {
        // Code for Q1: Check if a number is prime
        Console.Write("Enter a number for Q1: ");
        int n1 = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (n1 < 2) isPrime = false;
        else
        {
            for (int i = 2; i < n1; i++)
            {
                if (n1 % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
        }
        Console.WriteLine(isPrime ? "N is prime" : "N is non-prime");

        // Code for Q2: Print square pattern
        Console.Write("Enter a number for Q2: ");
        int n2 = int.Parse(Console.ReadLine());
        for (int i = 0; i < n2; i++)
        {
            for (int j = 0; j < n2; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        // Code for Q3: Print square pattern with a border
        Console.Write("Enter a number for Q3: ");
        int n3 = int.Parse(Console.ReadLine());
        for (int i = 0; i < n3; i++)
        {
            for (int j = 0; j < n3; j++)
            {
                if (i == 0 || i == n3 - 1 || j == 0 || j == n3 - 1)
                    Console.Write("* ");
                else
                    Console.Write("  ");
            }
            Console.WriteLine();
        }

        // Code for Bonus question: Print square pattern with diagonal
        Console.Write("Enter a number for Bonus: ");
        int nBonus = int.Parse(Console.ReadLine());
        for (int i = 0; i < nBonus; i++)
        {
            for (int j = 0; j < nBonus; j++)
            {
                if (i == 0 || i == nBonus - 1 || j == 0 || j == nBonus - 1 || i == j || j == nBonus - i - 1)
                    Console.Write("* ");
                else
                    Console.Write("  ");
            }
            Console.WriteLine();
        }
    }
}
