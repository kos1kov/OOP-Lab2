using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPforms
{
    [Serializable]
    class Cleaner : Employee
    {
        public bool NightShift { get; set; }


        public Cleaner(string name, int year, float salary, int DayOfHolidays, bool IsNightShift) : base(name, year, salary, DayOfHolidays)
        {
            NightShift = IsNightShift;
        }



        public override string Info()
        {
            return $"{(NightShift ? "Cleaner is working in nightshift" : "Cleaner is at dayshift")}";
        }
    }
}
