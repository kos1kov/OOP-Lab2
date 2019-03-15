using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPforms
{
    public class Manager:Employee
    {
        public float Premium;
        public string Department;
        public int Experience;

        public Manager(string name, int year, float salary, int DayOfHolidays, string Department, int Experience) : base(name, year, salary, DayOfHolidays)
        {
            this.Department = Department;
            this.Experience = Experience;
        }




    }
}
