using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace test_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company bmz = new Company("БМЗ", 1999);
            bmz.year = 1999;
            List<string> equip = new List<string>();
            equip.Add("hi");
            equip.Add("no");
            Console.WriteLine($"{bmz.name}, {bmz.year}");
            Owner pers = new Owner("vovan", 1999, 1, new Manager("123", 1000, 1, 2, "valve", 100), new Engineer("1", 1999, equip, 10, 20));
            Console.WriteLine($"{pers.name}, {pers.year}, {pers.budget}");
            Employee tom = new Employee ("hui", 1999, 100);
            tom.Info();
            Manager alex = new Manager("123", 1000, 1, 2, "valve", 100);
            alex.Info();
            Console.WriteLine(alex.FullSalary());
            Engineer dog = new Engineer("1", 1999, equip, 10, 20);
            dog.Info();

            Console.ReadKey();
            
           
        }
    }
}
