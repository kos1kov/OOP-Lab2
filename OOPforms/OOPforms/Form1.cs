using System;
using System.Collections.Generic;
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
            create<Company>(0);
            create<Owner>(1);
            create<Manager>(2);
            create<Employee>(3);
            create<Engineer>(4);
            create<Cleaner>(5);



            void create<T>(int number)
            {
                Type name = typeof(T);
                FieldInfo[] myField = name.GetFields();
                GroupBox gb = new GroupBox
                {
                    Name = name.Name.ToString(),
                    Text = name.Name.ToString(),
                    Width = 200,
                    Height = 70 * myField.Length,
                    Location = new Point(200*number, 10),

                };
                Controls.Add(value: gb);
                for (int i = 0; i <= myField.Length - 1; i++)
                {
                    Label lb = new Label
                    {
                        Text = myField[i].Name.ToString(),
                        Left = 45,
                        Top = (47 * i) + 15

                    };
                    gb.Controls.Add(lb);
                    TextBox tb = new TextBox
                    {
                        Left = 45,
                        Top = (47 * i) + 40,
                        Height = 15,
                        Width = 100
                    };
                    gb.Controls.Add(tb);
                }
            }


        }




        private void button1_Click(object sender, EventArgs e)
        {

            List<Company> numbers = new List<Company>();
            numbers.Add((Company)comboBox1.SelectedValue);

            MessageBox.Show(numbers[0].year.ToString());
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
