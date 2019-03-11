using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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




        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
            string strReport = "ReportViewer." + comboBox1.SelectedValue;
            MessageBox.Show(strReport);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Dictionary<string, Company> comboSource = new Dictionary<string, Company>();
            comboSource.Add("Company", new Company(string.Empty, 0));
            comboSource.Add("Owner", new Owner(string.Empty, 0, 0, null, null));
            comboSource.Add("Employee", new Employee(string.Empty,0,0));
            comboSource.Add("Manager", new Manager(string.Empty,0,0,0,string.Empty,0));
            comboSource.Add("Engineer", new Engineer(string.Empty,0,null,0,0));
            comboSource.Add("Cleaner", new Cleaner(string.Empty,0,0,false,0));
            comboBox1.DataSource = new BindingSource(comboSource, null);
            comboBox1.DisplayMember = "Key";
            comboBox1.ValueMember = "Value";
           
        }
    }
}
