using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOPforms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           

        }
    
        public List<Company> CompanyList = new List<Company>();
        public List<Owner> OwnerList = new List<Owner>();
        public List<Manager> ManagerList = new List<Manager>();
        public List<Engineer> EngineerList = new List<Engineer>();
        

        public int numbers = 0;
       private List<Cleaner> CleanerList = new List<Cleaner>();
        private void button1_Click(object sender, EventArgs e)
        {
            // string key = ((KeyValuePair<string, Company>)comboBox1.SelectedItem).Key;//Company

            Company company = new Company(CompanyName.Text, int.Parse(CompanyYear.Text));

            CompanyList.Add(company);

        }
        public Dictionary<string, Company> comboSource = new Dictionary<string, Company>();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Owner owner = new Owner(OwnerName.Text, int.Parse(OwnerYear.Text), float.Parse(OwnerBudget.Text), null, null);


            OwnerList.Add(owner);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager(ManagerName.Text, int.Parse(ManagerYear.Text), float.Parse(ManagerSalary.Text), int.Parse(ManagerDayOfHolidays.Text),
                ManagerDepartment.Text, int.Parse(ManagerExperience.Text));

            ManagerList.Add(manager);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Engineer engineer = new Engineer(EngineerName.Text, int.Parse(EngineerYear.Text), float.Parse(EngineerSalary.Text), int.Parse(EngineerDayOfHolidays.Text),
                null);

            EngineerList.Add(engineer);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cleaner cleaner = new Cleaner(EngineerName.Text, int.Parse(EngineerYear.Text), float.Parse(EngineerSalary.Text), int.Parse(EngineerDayOfHolidays.Text),
                bool.Parse(CleanerNightShift.SelectedValue.ToString())
                );

            CleanerList.Add(cleaner);
        }
    }
}
