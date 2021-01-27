using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medium_4
{
    class Program
    {
        static void Main(string[] args)
        {

            int check = 1;

            Employee emp = new Employee();

            while (check == 1)
            {

                emp.TakeEmployeeDetailsFromUser();

                try
                {
                    Console.WriteLine("To continue entering employee details enter 1, to exit enter 0");
                    check = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Enter Either 1 or 0 !!!");
                }
            }

            emp.SortAndPrintEmployees();
            emp.PrintEmployee();

            Console.ReadKey();
        }
    }
}