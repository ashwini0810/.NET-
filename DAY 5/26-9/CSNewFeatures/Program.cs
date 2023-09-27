using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace CSNewFeatures
{
   // delegate long MyDelegate(int n1, int n2);
   partial class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime? DOJ { get; set; }

    }
   partial class Student
    {
        public string Display()
        {
            return $"{Id}  {Name}";
        }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student { Id = 10, Name = "Student1" };

            List<Student> students = new List<Student>
            {
                student,
                new Student { Id = 20, Name = "Student2" },
                new Student { Id = 30, Name = "Student3" },
                new Student { Id = 40, Name = "Student4" }
            };

            Dictionary<int, Student> dictStuds = new Dictionary<int, Student>
            {
                {10,new Student { Id = 10, Name = "Student1" } },
                {20,new Student { Id = 20, Name = "Student2" } }
            };

            var i = 10;
            var st = "hello";
            var sal = 34343.3;

           var emp = new { EmpId = 1, Name = "Emp1", DOB = new DateTime(1991, 1, 1) };

            //MyDelegate del = new MyDelegate(Add);
            //MyDelegate del = delegate (int x, int y)//in-line functions
            //{
            //    return x + y;
            //};

            //MyDelegate del = (x, y) => x + y;

            Func<int,int,long> del = (x, y) => x + y;


            Console.WriteLine(del.Invoke(22,22));

            //foreach (Student item in students)
            //{
            //    Console.WriteLine(item.Name);
            //}

            //Action<Student> printaction = delegate (Student std)
            //{
            //    Console.WriteLine(std.Name);
            //};

            //students.ForEach(delegate (Student std)
            //{
            //    Console.WriteLine(std.Name);
            //});
            students.ForEach( (std)=>    Console.WriteLine(std.Name));

            string str = "hello";


            string s = null;
            // System.Nullable< int> ii = null;
            int? ii = null;

           // dynamic s1 = new Student(); //ViewBag
            //s1.GetFees();

        }

        //static long Add(int n1,int n2)
        //{
        //    return n1 + n2;
        //}
    }
}
