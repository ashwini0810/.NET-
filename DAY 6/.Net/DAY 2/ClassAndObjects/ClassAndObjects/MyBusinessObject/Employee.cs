using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.MyBusinessObject
{

    internal class Employee
    {

        private static int EmpCounter;
        
        internal Employee()
        {
           this.DOB = DateTime.Now;
            EmpCounter++;
        }

        public Employee(int eid,string name,DateTime dob) : this()
        {
            EmployeeId = eid;
            Name = name;
            DOB = dob;
            // Salary = 20000;
            Salary = new Salary(7000, 20, 15);
        }

        private int m_intEmployeeId;

        public static int EmployeeCounter
        {
            get
            {
                return EmpCounter;
            }
        }
        public int EmployeeId
        {
            get
            {
                return m_intEmployeeId;  
            }
            set
            {
                if (value > 0)
                    m_intEmployeeId = value;
                else
                    throw new Exception("Invalid employee id");
            }
        }

      

        private string m_strName;

        public string Name
        {
            get { return m_strName; }
            set {
                if(value.Length >3)
                m_strName = value;
                else
                    throw new Exception("Name should be atleast 3 chars");
            }
        }

        private DateTime m_dtDOB;

        public DateTime DOB
        {
            get { return m_dtDOB; }
            set {
                if (value.CompareTo(DateTime.Now) <= 0)
                    m_dtDOB = value;
                else
                    throw new Exception("Invalid DOB");
            }
        }

        //private double m_dblSal;

        //public double Salary
        //{
        //    get { return m_dblSal; }
        //    set { m_dblSal = value; }
        //}

        private Salary m_sal;

        public Salary Salary
        {
            get { return m_sal; }
            set { m_sal = value; }
        }

        public Gender Gender;

        StringBuilder sb;
        public string Display()
        {
            sb = new StringBuilder();
            sb.Append("Employee Id " + EmployeeId + "\n");
            sb.Append("Employee Name " + Name + "\n");
            sb.Append("Employee DOB " + DOB.ToShortDateString() + "\n");
            sb.Append("Employee salary " + Salary.GetNetSalary() + "\n");
            if (Gender == Gender.Male)
                sb.Append("Gender : Male\n");
            else
                sb.Append("Gender : Female\n");
            string msg = sb.ToString();
            return msg;
        }

        public void Dispose()
        {
            sb = null;
            Console.WriteLine("Release both critical and non-critical resoures here");
        }

        //Finalize
        //Resources
        //Critical
        //DB connections,pointers,Graphics object etc

        //Non-critical
        //array,collections and dotnet object
        ~Employee()
        {
            Console.WriteLine("Destructors are indeterministic in .net");
        }
    }
}
