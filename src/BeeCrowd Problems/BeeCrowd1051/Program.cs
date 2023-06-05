//==== BeeCrwod 1050 | Not Complited ====>
double salary, tax = 0;
salary = double.Parse(Console.ReadLine());

if (salary > 2000.00)
{
    salary = salary - 2000.00;
    if(salary>0 && salary <= 1000.00)
    {
        tax = (salary * 0.08);
    }
    else
    {
        tax = salary * 0.18;
        salary = salary - 1000;

    }
    if (salary > 0 && salary <= 1500.00)
    {
        tax = (salary * 0.18);
    }
    else
    {
        tax = salary * 0.28;
        salary = salary - 1500;

    }
}
else
{
    Console.WriteLine("Isento");
}
