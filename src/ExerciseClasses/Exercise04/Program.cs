// See https://aka.ms/new-console-template for more information
using Exercise04;

Student student = new Student("Zihad");

student.addGrade(100);
student.addGrade(80);
student.addGrade(50);
student.addGrade(10);

double avarageGrade = student.CalculateAvarageGrade();
Console.WriteLine($"{student.Name}'s avarage grade is: {avarageGrade}");


