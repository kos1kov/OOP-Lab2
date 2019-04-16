using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPforms
{
    [Serializable]
    public class Manager:Employee
    {
        public string Department { get; set; }
        public int Experience { get; set; }

        public Manager(string name, int year, float salary, int DayOfHolidays, string Department, int Experience) : base(name, year, salary, DayOfHolidays)
        {
            this.Department = Department;
            this.Experience = Experience;
        }




    }
}
