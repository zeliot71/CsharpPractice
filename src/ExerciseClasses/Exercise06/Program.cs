// See https://aka.ms/new-console-template for more information

using Exercise06;

Company company= new Company();
Employee employee= new Employee
{
    EmployeeId = 174360,
    Name = "Zihad",
    Department = "It"
};
company.AddEmployee(employee);
Employee employee1 = new Employee 
{ 
    EmployeeId = 174361,
    Name = "Zahid",
    Department = "CS"

};
company.AddEmployee(employee1);


company.DsplayEmployee();

company.RemoveEmployee(174361);

company.DsplayEmployee();