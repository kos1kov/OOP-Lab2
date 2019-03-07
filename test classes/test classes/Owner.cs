using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_classes
{
   public class Owner:Company
    {
        public float budget;
        public Owner()
        {
        }
        public Owner(float budget)
        {
            this.budget = budget;
        }
    }
}
