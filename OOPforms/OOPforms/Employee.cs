using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPforms
{
    public class Employee:Company
    {
        public float salary;

        public Employee(string name, int year, float salary) : base(name, year)
        {
            this.salary = salary;
        }

        public virtual string Info()
        {
           return $"Name : {name}, year: {year}, salary:  {salary}";
        }
    }
}
