using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company bmz = new Company("БМЗ");
            bmz.year = 1999;
            Console.WriteLine($"{bmz.name}, {bmz.year}");
            Owner pers = new Owner { name = "John", year = 2000, budget = 20000 };
            Console.WriteLine($"{pers.name}, {pers.year}, {pers.budget}");
            Employe tom = new Employe { name = "John", salary = 20000 };
            tom.printInfo();
            Manager alex = new Manager {Premium = 100,Department = "финансовый", name = "alex",salary = 500 };
            alex.printInfo();
            Console.WriteLine(alex.FullSalary(alex.Premium, alex.salary));
            Console.ReadKey();
            
           
        }
    }
}
