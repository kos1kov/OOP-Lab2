using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_classes
{
   public class Company
    {
        public string name;
        public int year;
        public Company()
        {
        }
        public Company(string name)
        {
            this.name = name;
        }
       public Company(string name,int year) : this(name)
        {
            this.year = year;

        }

    }
}
