using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubjectLib
{
    public class Subject : IId<int>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Theory : Subject
    {
        public string Lecturer { get; set; }
    }
    public class Lab : Subject
    {
        public int InternalMarks { get; set; }
    }
}

