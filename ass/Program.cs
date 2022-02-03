using System;

namespace ass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            regular obj1 = new regular(1, 101, "padmaj", 33000.00, 500.00,new DateTime(2022,01,10));
            obj1.GetEmployeeDetails(1);
            Console.WriteLine(obj1.GetSalaryInfo(1));

            contract obj2 = new contract(1, 101, "akshat", 1000.55, 500.00, new DateTime(2022, 01, 10));
            obj2.GetEmployeeDetails(1);
            Console.WriteLine(obj2.GetSalaryInfo(1));
        }
    }
}