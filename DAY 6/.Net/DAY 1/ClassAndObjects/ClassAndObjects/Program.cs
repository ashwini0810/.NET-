using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassAndObjects.MyBusinessObject;
namespace ClassAndObjects
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Employee emp1, emp2;

            emp1 = new Employee();
            emp1.EmployeeId = 10;
            emp1.Name = "Name1";
            emp1.Salary = 22323.2;
            emp1.DOB = new DateTime(1999, 1, 12);

            emp2 = new Employee(20, "Name2", Convert.ToDateTime("12/3/2000"));
            //emp2.EmployeeId = 20;
            //emp2.Name = "Name2";
            //emp2.Salary = 78788.2;
            //emp2.DOB = Convert.ToDateTime("12/3/2000");

            Console.WriteLine(emp1.EmployeeId);
            if (true)
            {
                Employee emp3 = new Employee();
                emp3 = null;     
            }

            Console.WriteLine(emp1.Display());
            Console.WriteLine(emp2.Display());

            //Console.WriteLine("There are " + Employee.EmpCounter + " employee objects");
            //Console.WriteLine("There are {0} employee objects",Employee.EmpCounter);
            string msg = $"There are {Employee.EmployeeCounter} employee objects";
            //Employee.EmpCounter = 100;
            Console.WriteLine(msg);

            emp1.Dispose();
            emp2.Dispose(); 

            //emp1 = null;
           // emp2 = null;
            GC.Collect();
            Console.ReadLine();
        }
    }
}
