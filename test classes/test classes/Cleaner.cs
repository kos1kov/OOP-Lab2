using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_classes
{
    class Cleaner : Employee
    {
        public bool NightShift;
        public int holidays;

        public Cleaner(string name, int year, float salary, bool IsNightShift, int numOfHolidays) : base(name, year, salary)
        {
            NightShift = IsNightShift;
            holidays = numOfHolidays;
        }

        public override string Info()
        {
            return $"{(NightShift ? "Cleaner is working in nightshift" : "Cleaner is at dayshift")}, number of holidays: {holidays}";
        }
    }
}
