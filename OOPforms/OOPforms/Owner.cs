using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace OOPforms
{
   public class Owner : Company
    {
        public float budget;

        public Owner(string name, int year, float budget, Manager manager, Engineer engineer) : base(name, year)
        {
            this.budget = budget;
            this.manager = manager;
            this.engineer = engineer;
        }

        public Manager manager;
        public Engineer engineer;
        
    }
}
