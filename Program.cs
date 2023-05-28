using System;

namespace Object_Oriented_Programming_Inheritance
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Single Inheritance

            Console.WriteLine("-----Single Inheritance-----");
            Employee emp = new Employee(111, 50000, "Jack Ryan", 30);

            emp.DisplayInfo();

            // Multilevel Inheritance

            Console.WriteLine("\n-----Multilevel Inheritance-----");
            SBI sbi = new SBI();

            Console.WriteLine("Enter the amount you want to invest?");
            int amount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("How many time you want to invest (in years)?");
            int years = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your amount according to Bank of India policies after {0} years will be {1}.", years, sbi.CalculateBOIBalance(amount, years));
            Console.WriteLine("Your amount according to Union Bank of India policies after {0} years will be {1}.", years, sbi.CalculateUnionBalance(amount, years));
            Console.WriteLine("Your amount according to State Bank of India policies after {0} years will be {1}.", years, sbi.CalculateSBIBalance(amount, years));

            
        }
    }
}