using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass
{
    internal class regular: employee
    {
        public regular(int employeeId, int departmentId, string name, double salary, double bonus, DateTime joiningDate) : base(employeeId, departmentId, name, salary, bonus, joiningDate)
        {
            this.EmployeeId = employeeId;
            this.Name = name;
            this.Salary = salary;
            this.Bonus = bonus;
            this.JoiningDate = joiningDate.Date;
            this.DepartmentId = departmentId;
        }


        public override void GetEmployeeDetails(int EmployeeId)
        {
            Console.WriteLine("****REGULAR EMPLOYEE DETAILS****");
            Console.WriteLine($"Employee Id = {EmployeeId}  Name = {Name}  Departement ID = {DepartmentId}   Joining Date = {JoiningDate}");

        }

        public override double GetSalaryInfo(int EmployeeID)
        {
            Double TotalSalary = Salary + Bonus; 
            return TotalSalary ;
        }


    }
}