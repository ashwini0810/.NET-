using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAndObjects.MyBusinessObject
{
    internal struct Salary 
    {
        internal double Basic;
        internal byte Ta,  Hra;

        public Salary(double bas,byte ta,byte hra)
        {
            Basic = bas;
            Ta = ta;
            Hra = hra;
        }

        public double GetNetSalary()
        {
            return Basic + (Basic * Convert.ToDouble(Ta) / 100) 
                + (Basic * Convert.ToDouble(Hra) / 100);
        }
    }
}
