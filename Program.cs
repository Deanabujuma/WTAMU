using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        // Create Customer objects
        Customer cus1 = new Customer("Alice", 33, "Amarillo", 198.5);
        Customer cus2 = new Customer("Bob", 23, "Amarillo", 226);
        Customer cus3 = new Customer("Cathy", 45, "Amarillo", 89.0);
        Customer cus4 = new Customer("David", 58, "Amarillo", 198.5);
        Customer cus5 = new Customer("Jack", 28, "Canyon", 561.6);
        Customer cus6 = new Customer("Tom", 36, "Canyon", 98.4);
        Customer cus7 = new Customer("Tony", 24, "Canyon", 18.5);
        Customer cus8 = new Customer("Sam", 35, "Canyon", 228.3);

        Customer[] customer_list = { cus1, cus2, cus3, cus4, cus5, cus6, cus7, cus8 };

        // Call Q1 method
        TotalCredits(customer_list);
        // Call Q2 method
        AmarilloAverageAge(customer_list);
        // Call Q3 method
        CanyonAge(customer_list);
    }

    // Q1: Calculate and print the total credit of all customers
    public static void TotalCredits(Customer[] customer_list)
    {
        double totalCredit = customer_list.Sum(c => c.CustomerCredit);
        Console.WriteLine($"Total Credit: {totalCredit}");
    }

    // Q2: Calculate and print the average age of customers living in Amarillo
    public static void AmarilloAverageAge(Customer[] customer_list)
    {
        var amarilloCustomers = customer_list.Where(c => c.CustomerCity == "Amarillo").ToList();
        if (amarilloCustomers.Count > 0)
        {
            double averageAge = amarilloCustomers.Average(c => c.CustomerAge);
            Console.WriteLine($"Average Age in Amarillo: {averageAge:F2}");
        }
        else
        {
            Console.WriteLine("No customers in Amarillo.");
        }
    }

    // Q3: Print names of customers who live in Canyon and are older than 30
    public static void CanyonAge(Customer[] customer_list)
    {
        var canyonCustomers = customer_list.Where(c => c.CustomerCity == "Canyon" && c.CustomerAge > 30);
        Console.WriteLine("Customers in Canyon older than 30:");
        foreach (var customer in canyonCustomers)
        {
            Console.WriteLine(customer.CustomerName);
        }
    }
}

// Q0: Customer class definition
class Customer
{
    public string CustomerName { get; set; }
    public int CustomerAge { get; set; }
    public string CustomerCity { get; set; }
    public double CustomerCredit { get; set; }

    public Customer(string customerName, int customerAge, string customerCity, double customerCredit)
    {
        CustomerName = customerName;
        CustomerAge = customerAge;
        CustomerCity = customerCity;
        CustomerCredit = customerCredit;
    }
}
