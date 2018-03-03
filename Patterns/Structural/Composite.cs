using System;
using System.Collections.Generic;

namespace Patterns.Structural
{
    /// <summary>
    /// Composite
    /// Компоновщик
    /// https://proglib.io/p/structural-patterns/
    /// </summary>

    public class Composite
    {
        public void Using()
        {
            var john = new Developer("John", 12000);
            var jane = new Designer("Jane", 15000);
            var organization = new Organisation();
            organization.AddEmployee(john);
            organization.AddEmployee(jane);
            Console.WriteLine($"The organisation's total salary is {organization.GetNetSalaries()}");
        }
    }

    public abstract class Employee
    {
        protected string name;
        protected float salary;

        public Employee(string name, float salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string GetName() {
            return name;
        }

        public void SetSalary(float salary)
        {
            this.salary = salary;
        }

        public float GetSalary()
        {
            return salary;
        }
    }

    public class Developer : Employee
    {
        public Developer(string name, float salary) : base(name, salary){}
    }

    public class Designer : Employee
    {
        public Designer(string name, float salary) : base(name, salary) { }
    }

    public class Organisation
    {
        List<Employee> employees = new List<Employee>();

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public float GetNetSalaries()
        {
            float netSalary = 0;
            foreach(var e in employees)
            {
                netSalary += e.GetSalary();
            }
            return netSalary;
        }
    }
}
