using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace CollectionDemo
{
    class Student
    {
        //Auto property proc
        public int Id { get; set; }
        public string Name { get; set; }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Item1");
            al.Add("Item3");
            al.Add("Item4");
            al.Add("Item5");
            al.Insert(1, "Item2");
            string[] arr = { "Item6", "Item7" };
            al.AddRange(arr);

            //al.RemoveAt(2);
            int i = 10;
            al.Add(i);//boxing it is implicit
            i = (int)al[7];//unboxing it is explicit

            foreach (object item in al)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Count {al.Count} and capacity {al.Capacity}");

            Hashtable hashtable = new Hashtable();

            Student student = new Student { Id = 1, Name = "Student1" };
            hashtable.Add(student.Id, student);
            hashtable.Add(2, new Student { Id = 2, Name = "Student2" });
            hashtable.Add(3, new Student { Id = 3, Name = "Student3" });
            hashtable.Add(4, new Student { Id = 4, Name = "Student4" });
            Student std1 = hashtable[2] as Student;

            //hashtable.Remove(2)

            foreach (Student item in hashtable.Values)
            {
                Console.WriteLine(  item.Name);
            }
        }
    }
}
