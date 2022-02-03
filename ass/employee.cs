using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ass
{
    public class employee
    {
        public int EmployeeId, DepartmentId;
        public Double Salary, Bonus;
        public string Name;
        public DateTime JoiningDate;
        public employee(int employeeId,int departmentId, string name, Double salary, Double bonus, DateTime joiningDate )
        {
            this.EmployeeId = employeeId;
            this.Name = name;
            this.Salary = salary;
            this.Bonus = bonus;
            this.JoiningDate = joiningDate.Date;
            this.DepartmentId = departmentId;

        }

        public virtual void GetEmployeeDetails(int EmployeeId)
        {
            Console.WriteLine($"Employee Id = {EmployeeId}  Name = {Name}  Departement ID = {DepartmentId}   Joining Date = {JoiningDate}");
        }

        public virtual Double GetSalaryInfo(int EmployeeID)
        {
            Double TotalSalary = Salary + Bonus;
            return TotalSalary;
        }
    }
}