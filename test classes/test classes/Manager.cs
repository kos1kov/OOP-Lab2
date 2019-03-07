using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_classes
{
    public class Manager:Employee
    {
        public float Premium;
        public string Department;
        public int Experience;

        public Manager(string name, int year, float salary, float Premium, string Department, int Experience) : base(name, year, salary)
        {
            this.Premium = Premium;
            this.Department = Department;
            this.Experience = Experience;
        }

        public float FullSalary()
        {
            return Premium + salary;
        }
    }
}
