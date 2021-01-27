using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium_4
{
    class Employee : IComparable<Employee>
    {
        int id, age;
        string name;
        double salary;

        List<Employee> employees = new List<Employee>();

        public Employee()
        {
        }

        public Employee(int id, int age, string name, double salary)
        {
            this.id = id;
            this.age = age;
            this.name = name;
            this.salary = salary;
        }

        public void TakeEmployeeDetailsFromUser()
        {
            try
            {
                Console.WriteLine("Please enter the employee ID");
                id = int.Parse(Console.ReadLine());
                bool _employeeFound = false;

                foreach (Employee employee in employees)
                {
                    if (employee.id == id)
                        _employeeFound = true;
                }
                if (_employeeFound)
                {
                    Console.WriteLine("This ID has been already added !!! Use a new ID. ");
                    TakeEmployeeDetailsFromUser();
                    return;
                }
            }
            catch
            {
                Console.WriteLine("ID must be a number !!!");
                TakeEmployeeDetailsFromUser();
                return;
            }

            Console.WriteLine("Please enter the employee name");
            name = Console.ReadLine();

            try
            {
                Console.WriteLine("Please enter the employee age");
                age = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Age must be a number !!!");
                TakeEmployeeDetailsFromUser();
                return;
            }

            try
            {
                Console.WriteLine("Please enter the employee salary");
                salary = Double.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Salary must be a number !!!");
                TakeEmployeeDetailsFromUser();
                return;
            }


            employees.Add(new Employee(id, age, name, salary));
        }

        public override string ToString()
        {
            return "\nEmployee ID : " + id + "\nName : " + name + "\nAge : " + age + "\nSalary : " + salary + "\n";
        }

        public int CompareTo(Employee other)
        {

            if (this.Salary == other.Salary)
            {
                return this.Name.CompareTo(other.Name);
            }

            return other.Salary.CompareTo(this.Salary);
        }

        public void SortAndPrintEmployees()
        {
            employees.Sort();

            Console.WriteLine("The sorted employee list : ");

            foreach (var employee in employees)
            {
                Console.WriteLine(employee.ToString());
                Console.WriteLine("----------------------------------");
            }
        }

        public void PrintEmployee()
        {
            Console.WriteLine("Enter the ID of the Employee :");
            int id = Convert.ToInt32(Console.ReadLine());
            int age = 0;
            foreach (var employee in employees)
            {
                if (employee.id == id)
                {
                    age = employee.age;
                }
            }
            var query = from emp in employees where emp.age > age select emp;

            if (query.Count() != 0)
            {
                foreach (var employee in query)
                    Console.WriteLine(employee.ToString());
            }
            else
            {
                Console.WriteLine("No Employees are greater than Employee ID:{0}'s  age", id);
            }
        }


        public int Id { get => id; set => id = value; }
        public int Age { get => age; set => age = value; }
        public string Name { get => name; set => name = value; }
        public double Salary { get => salary; set => salary = value; }

    }
}