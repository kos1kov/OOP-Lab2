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

        public BindingList<Company> CompanyList = new BindingList<Company>();
        public BindingList<Owner> OwnerList = new BindingList<Owner>();
        public BindingList<Manager> ManagerList = new BindingList<Manager>();
        public BindingList<Engineer> EngineerList = new BindingList<Engineer>();

       private BindingList<Cleaner> CleanerList = new BindingList<Cleaner>();
        private void button1_Click(object sender, EventArgs e)
        {
            Company company = new Company(CompanyName.Text, int.Parse(CompanyYear.Text));
            CompanyName.Clear();
            CompanyYear.Clear();
            CompanyList.Add(company);
            Companydata.DataSource = null;
            Companydata.DataSource = CompanyList;
        }
        DataGridViewComboBoxColumn cmb = new DataGridViewComboBoxColumn();
        private void Form1_Load(object sender, EventArgs e)
        {

            Companydata.DataSource = CompanyList;
            Ownerdata.DataSource = OwnerList;
            Managerdata.DataSource = ManagerList;
            Engineerdata.DataSource = EngineerList;
            Cleanerdata.DataSource = CleanerList;
            
            cmb.HeaderText = "Equipment";
            cmb.Name = "cmb";
            cmb.MaxDropDownItems = 10;
            
            Engineerdata.Columns.Add(cmb);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Owner owner = new Owner(OwnerName.Text, int.Parse(OwnerYear.Text), float.Parse(OwnerBudget.Text), null);
            OwnerName.Clear();
            OwnerYear.Clear();
            OwnerBudget.Clear();

            OwnerList.Add(owner);
            Ownerdata.DataSource = null;
            Ownerdata.DataSource = OwnerList;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager(ManagerName.Text, int.Parse(ManagerYear.Text), float.Parse(ManagerSalary.Text), int.Parse(ManagerDayOfHolidays.Text),
            ManagerDepartment.Text, int.Parse(ManagerExperience.Text));
            ManagerList.Add(manager);
            Managerdata.DataSource = null;
            Managerdata.DataSource = ManagerList;
        }
        List<string> tmpList = new List<string>();
       
        private void button5_Click(object sender, EventArgs e)
        {

            Engineer engineer = new Engineer(EngineerName.Text, int.Parse(EngineerYear.Text), float.Parse(EngineerSalary.Text), int.Parse(EngineerDayOfHolidays.Text),
                tmpList);
 
          
            EngineerName.Clear();
            EngineerYear.Clear();
            EngineerSalary.Clear();
            EngineerDayOfHolidays.Clear();

            EngineerList.Add(engineer);
            Engineerdata.DataSource = null;
            Engineerdata.DataSource = EngineerList;
            tmpList.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool tmp;
            if (CleanerNightShift.SelectedItem.ToString() == "да")
            {
                 tmp = true;
            }else
            {
                tmp = false;
            }
            Cleaner cleaner = new Cleaner(CleanerName.Text, int.Parse(CleanerYear.Text), float.Parse(CleanerSalary.Text), int.Parse(CleanerDayOfHolidays.Text),
                tmp);
            CleanerName.Clear();
            CleanerYear.Clear();
            CleanerSalary.Clear();
            CleanerDayOfHolidays.Clear();
            CleanerList.Add(cleaner);
            Cleanerdata.DataSource = null;
            Cleanerdata.DataSource = CleanerList;
        }



        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Cleanerdata.Visible = false;
            Companydata.Visible = false;
            Ownerdata.Visible = false;
            Managerdata.Visible = false;
            Engineerdata.Visible = false;
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    Companydata.Visible = true;
                    break;
                case 1:
                    Ownerdata.Visible = true;
                    break;
                case 2:
                    Managerdata.Visible = true;
                    break;
                case 3:
                    Engineerdata.Visible = true;
                    break;
                case 4:
                    Cleanerdata.Visible = true;
                    break;
                default:
                   
                    break;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            tmpList.Add(EngineerEquipment.Text);
            EngineerEquipment.Clear();
        }
    }
}
