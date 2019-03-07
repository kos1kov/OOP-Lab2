using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_classes
{
    class Manager:Employe
    {
        public float Premium;
        public string Department;
        public int Experience;
        public Manager()
        {
        }
        public Manager(float Premium)
        {
            this.Premium = Premium;
        }
        public Manager(float Premium,string Department) : this(Premium)
        {
            this.Department = Department;
        }
        public Manager(float Premium, string Department,int Experience) : this(Premium,Department)
        {
            this.Experience = Experience;
        }
        public float FullSalary(float Premium, float Salary)
        {
            return Premium + Salary;
        }
    }
}
