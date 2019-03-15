using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPforms
{
   public class Company
    {
        public string name { get; set; }
        public int year { get; set; }

        public Company(string name,int year)
        {
            this.year = year;
            this.name = name;
        }

    }
}
