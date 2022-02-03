using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass 
{
    internal class contract : employee
    {
        public contract(int employeeId, int departmentId, string name, double salary, double bonus, DateTime joiningDate) : base(employeeId, departmentId, name, salary, bonus, joiningDate)
        {
            this.EmployeeId = employeeId;
            this.Name = name;
            this.Salary = salary;
            this.Bonus = bonus;
            this.JoiningDate = joiningDate;
            this.DepartmentId = departmentId;
        }

        public override void GetEmployeeDetails(int EmployeeId)
        {
            Console.WriteLine("****CONTRACT EMPLOYEE DETAILS****");
            Console.WriteLine($"Employee Id = {EmployeeId}  Name = {Name}  Departement ID = {DepartmentId}   Joining Date = {JoiningDate}");

        }

        public override double GetSalaryInfo(int EmployeeID)
        {
            Double TotalSalary = Salary + ((Salary/100)*3);
            return TotalSalary;
        }
    }
}