using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
    }

    public class Company
    {
        public List<Employee> Employees { get; set;} = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
           
            Employees.Add(employee);
        }
        public void RemoveEmployee(int employeeId)
        {
           Employee employee= Employees.FirstOrDefault(emp => emp.EmployeeId== employeeId);
            if (employee != null)
            {
                Employees.Remove(employee);
            }
        } 

        public void DsplayEmployee()
        {
            foreach (Employee emp in Employees)
            {
                Console.WriteLine(emp.EmployeeId);
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.Department);
            }
        }
    }
}
