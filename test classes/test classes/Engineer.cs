using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_classes
{
    public class Engineer: Employee
    {
       
        public  List<string> equipment;
        public int holidays;

        public Engineer(string name, int year, List<string> equip, int holiday, float salary) : base(name, year, salary)
        {
            this.equipment = equip;
            this.holidays = holiday;
        }

        public override string Info()
        {
         return $"{name}, {year}, {salary}, {holidays}";
        }
    }
}
