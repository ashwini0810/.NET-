using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Person
    {
        public Person()
        {
            Console.WriteLine("ctor of base called");
        }
        public void Name()
        {
            Console.WriteLine("Name called");
        }
        public  void DOB()
        {
            Console.WriteLine("DOB of base called");
        }
        private void PrivM()
        {

        }
        protected void ProtecM()
        {
            Console.WriteLine("ProtecM called");
        }
        protected internal void PIM()
        {
            Console.WriteLine("PIM called");
        }
    }

    class Employee : Person
    {
        public Employee()
        {
            Console.WriteLine("ctor of derived called");
        }
        public void Salary()
        {
            Console.WriteLine("Salary of derived called");
        }
        public new void DOB()
        {
            Console.WriteLine("DOB of derived called");
           // base.DOB();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            //Early binding
            Person obj = new Person();
          //  obj.DOB();

            Employee obj2 = new Employee();
            //obj2.DOB();

            //late binding
            Person obj3 = new Employee();//up-casting it is implicit
            obj3.DOB();

            Employee obj5 = (Employee) obj3;//down-casting it is explicit
            //obj5.DOB();

            object obj4 = new Employee();

            Employee obj6 = (Employee)obj4;//static casting syntax

            Employee obj7 = obj4 as Employee;//dynamic casting syntax
            //if (obj7 != null)
            //{
            //    obj7.DOB();
            //}

            //obj7?.DOB();

        }
    }
}
