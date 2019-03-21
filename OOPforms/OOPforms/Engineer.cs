using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPforms
{
    public class Engineer: Employee
    {
       
        public string equipment { get; set; }

        public Engineer(string name, int year, float salary, int DayOfHolidays, string equip) : base(name, year, salary, DayOfHolidays)
        {
            this.equipment = equip;
        }


        public override string Info()
        {
         return $"{name}, {year}, {salary}, {DayOfHolidays}";
        }
    }
}
