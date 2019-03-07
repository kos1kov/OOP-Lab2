using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_classes
{
    class Employe:Company
    {
        public float salary;
        public Employe()
        {
        }
        public Employe(float salary)
        {
            this.salary = salary;
        }
        public void printInfo()
        {
            Console.WriteLine($"{name}, {year}, {salary}");
        }
    }
}
