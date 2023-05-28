using System;

namespace Object_Oriented_Programming_Inheritance
{

    // Single Inheritance: A derived class that inherits from only one base class.
    internal class Person
    {
        public string name;
        public int age;

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    internal class Employee: Person
    {
        public int emp_id;
        public int emp_salary;

        public Employee(int id, int salary, string name, int age) : base(name, age)
        {
            this.emp_id = id;
            this.emp_salary = salary;
        }

        public void DisplayInfo()
        {
            Console.WriteLine("Employee ID: " + emp_id);
            Console.WriteLine("Employee Name: " + name);
            Console.WriteLine("Employee Age: " + age);
            Console.WriteLine("Employee Salary: " + emp_salary);
        }
    }
}
