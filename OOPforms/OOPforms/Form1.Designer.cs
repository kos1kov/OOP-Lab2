namespace OOPforms
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.CompanyYear = new System.Windows.Forms.TextBox();
            this.CompanyName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.OwnerBudget = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.OwnerYear = new System.Windows.Forms.TextBox();
            this.OwnerName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.form1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.form1BindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ManagerDayOfHolidays = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ManagerExperience = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ManagerDepartment = new System.Windows.Forms.TextBox();
            this.ManagerSalary = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ManagerYear = new System.Windows.Forms.TextBox();
            this.ManagerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.EngineerEquipment = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.EngineerDayOfHolidays = new System.Windows.Forms.TextBox();
            this.EngineerSalary = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.EngineerYear = new System.Windows.Forms.TextBox();
            this.EngineerName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CleanerNightShift = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(54, 244);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 24);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Label2);
            this.groupBox1.Controls.Add(this.CompanyYear);
            this.groupBox1.Controls.Add(this.CompanyName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(36, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 178);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Company";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(74, 74);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(38, 17);
            this.Label2.TabIndex = 9;
            this.Label2.Text = "Year";
            // 
            // CompanyYear
            // 
            this.CompanyYear.Location = new System.Drawing.Point(50, 94);
            this.CompanyYear.Name = "CompanyYear";
            this.CompanyYear.Size = new System.Drawing.Size(100, 22);
            this.CompanyYear.TabIndex = 8;
            this.CompanyYear.Text = "0";
            // 
            // CompanyName
            // 
            this.CompanyName.Location = new System.Drawing.Point(45, 49);
            this.CompanyName.Name = "CompanyName";
            this.CompanyName.Size = new System.Drawing.Size(100, 22);
            this.CompanyName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "name";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.OwnerBudget);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.OwnerYear);
            this.groupBox2.Controls.Add(this.OwnerName);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(41, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 229);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Owner";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 164);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Manager";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(45, 184);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 12;
            // 
            // OwnerBudget
            // 
            this.OwnerBudget.Location = new System.Drawing.Point(45, 139);
            this.OwnerBudget.Name = "OwnerBudget";
            this.OwnerBudget.Size = new System.Drawing.Size(100, 22);
            this.OwnerBudget.TabIndex = 11;
            this.OwnerBudget.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Budget";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Year";
            // 
            // OwnerYear
            // 
            this.OwnerYear.Location = new System.Drawing.Point(45, 94);
            this.OwnerYear.Name = "OwnerYear";
            this.OwnerYear.Size = new System.Drawing.Size(100, 22);
            this.OwnerYear.TabIndex = 8;
            this.OwnerYear.Text = "0";
            // 
            // OwnerName
            // 
            this.OwnerName.Location = new System.Drawing.Point(45, 49);
            this.OwnerName.Name = "OwnerName";
            this.OwnerName.Size = new System.Drawing.Size(100, 22);
            this.OwnerName.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "name";
            // 
            // form1BindingSource
            // 
            this.form1BindingSource.DataSource = typeof(OOPforms.Form1);
            // 
            // form1BindingSource1
            // 
            this.form1BindingSource1.DataSource = typeof(OOPforms.Form1);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Location = new System.Drawing.Point(567, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(366, 324);
            this.tabControl1.TabIndex = 8;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(358, 295);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(358, 295);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(77, 253);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(132, 24);
            this.button3.TabIndex = 7;
            this.button3.Text = "Добавить";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(358, 295);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ManagerDayOfHolidays);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.ManagerExperience);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.ManagerDepartment);
            this.groupBox3.Controls.Add(this.ManagerSalary);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.ManagerYear);
            this.groupBox3.Controls.Add(this.ManagerName);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(6, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 286);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Manager";
            // 
            // ManagerDayOfHolidays
            // 
            this.ManagerDayOfHolidays.Location = new System.Drawing.Point(46, 170);
            this.ManagerDayOfHolidays.Name = "ManagerDayOfHolidays";
            this.ManagerDayOfHolidays.Size = new System.Drawing.Size(100, 22);
            this.ManagerDayOfHolidays.TabIndex = 22;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(44, 150);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(102, 17);
            this.label17.TabIndex = 21;
            this.label17.Text = "DayOfHolidays";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(54, 237);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Experience";
            // 
            // ManagerExperience
            // 
            this.ManagerExperience.Location = new System.Drawing.Point(46, 257);
            this.ManagerExperience.Name = "ManagerExperience";
            this.ManagerExperience.Size = new System.Drawing.Size(100, 22);
            this.ManagerExperience.TabIndex = 19;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Department";
            // 
            // ManagerDepartment
            // 
            this.ManagerDepartment.Location = new System.Drawing.Point(46, 212);
            this.ManagerDepartment.Name = "ManagerDepartment";
            this.ManagerDepartment.Size = new System.Drawing.Size(100, 22);
            this.ManagerDepartment.TabIndex = 17;
            // 
            // ManagerSalary
            // 
            this.ManagerSalary.Location = new System.Drawing.Point(46, 125);
            this.ManagerSalary.Name = "ManagerSalary";
            this.ManagerSalary.Size = new System.Drawing.Size(100, 22);
            this.ManagerSalary.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(70, 105);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 17);
            this.label10.TabIndex = 15;
            this.label10.Text = "Salary";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(70, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(38, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Year";
            // 
            // ManagerYear
            // 
            this.ManagerYear.Location = new System.Drawing.Point(46, 81);
            this.ManagerYear.Name = "ManagerYear";
            this.ManagerYear.Size = new System.Drawing.Size(100, 22);
            this.ManagerYear.TabIndex = 13;
            this.ManagerYear.Text = "0";
            // 
            // ManagerName
            // 
            this.ManagerName.Location = new System.Drawing.Point(46, 34);
            this.ManagerName.Name = "ManagerName";
            this.ManagerName.Size = new System.Drawing.Size(100, 22);
            this.ManagerName.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(70, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 17);
            this.label9.TabIndex = 11;
            this.label9.Text = "name";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.button5);
            this.tabPage4.Controls.Add(this.groupBox4);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(358, 295);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "tabPage4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.EngineerEquipment);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.EngineerDayOfHolidays);
            this.groupBox4.Controls.Add(this.EngineerSalary);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.EngineerYear);
            this.groupBox4.Controls.Add(this.EngineerName);
            this.groupBox4.Controls.Add(this.label16);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 264);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Engineer";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(59, 195);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 17);
            this.label12.TabIndex = 20;
            this.label12.Text = "Equipment";
            // 
            // EngineerEquipment
            // 
            this.EngineerEquipment.Location = new System.Drawing.Point(51, 215);
            this.EngineerEquipment.Name = "EngineerEquipment";
            this.EngineerEquipment.Size = new System.Drawing.Size(100, 22);
            this.EngineerEquipment.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(43, 150);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(102, 17);
            this.label13.TabIndex = 18;
            this.label13.Text = "DayOfHolidays";
            // 
            // EngineerDayOfHolidays
            // 
            this.EngineerDayOfHolidays.Location = new System.Drawing.Point(46, 170);
            this.EngineerDayOfHolidays.Name = "EngineerDayOfHolidays";
            this.EngineerDayOfHolidays.Size = new System.Drawing.Size(100, 22);
            this.EngineerDayOfHolidays.TabIndex = 17;
            // 
            // EngineerSalary
            // 
            this.EngineerSalary.Location = new System.Drawing.Point(46, 125);
            this.EngineerSalary.Name = "EngineerSalary";
            this.EngineerSalary.Size = new System.Drawing.Size(100, 22);
            this.EngineerSalary.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(70, 105);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 17);
            this.label14.TabIndex = 15;
            this.label14.Text = "Salary";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(70, 61);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 17);
            this.label15.TabIndex = 14;
            this.label15.Text = "Year";
            // 
            // EngineerYear
            // 
            this.EngineerYear.Location = new System.Drawing.Point(46, 81);
            this.EngineerYear.Name = "EngineerYear";
            this.EngineerYear.Size = new System.Drawing.Size(100, 22);
            this.EngineerYear.TabIndex = 13;
            this.EngineerYear.Text = "0";
            // 
            // EngineerName
            // 
            this.EngineerName.Location = new System.Drawing.Point(46, 34);
            this.EngineerName.Name = "EngineerName";
            this.EngineerName.Size = new System.Drawing.Size(100, 22);
            this.EngineerName.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(70, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(43, 17);
            this.label16.TabIndex = 11;
            this.label16.Text = "name";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button2);
            this.tabPage5.Controls.Add(this.groupBox5);
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(358, 295);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "tabPage5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CleanerNightShift);
            this.groupBox5.Controls.Add(this.label18);
            this.groupBox5.Controls.Add(this.label19);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.textBox5);
            this.groupBox5.Controls.Add(this.label20);
            this.groupBox5.Controls.Add(this.label21);
            this.groupBox5.Controls.Add(this.textBox6);
            this.groupBox5.Controls.Add(this.textBox7);
            this.groupBox5.Controls.Add(this.label22);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(200, 264);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Cleaner";
            // 
            // CleanerNightShift
            // 
            this.CleanerNightShift.FormattingEnabled = true;
            this.CleanerNightShift.Items.AddRange(new object[] {
            "да",
            "нет"});
            this.CleanerNightShift.Location = new System.Drawing.Point(36, 213);
            this.CleanerNightShift.Name = "CleanerNightShift";
            this.CleanerNightShift.Size = new System.Drawing.Size(121, 24);
            this.CleanerNightShift.TabIndex = 21;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(59, 195);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(69, 17);
            this.label18.TabIndex = 20;
            this.label18.Text = "NightShift";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(43, 150);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(102, 17);
            this.label19.TabIndex = 18;
            this.label19.Text = "DayOfHolidays";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(46, 170);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 17;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(46, 125);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 16;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(70, 105);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(48, 17);
            this.label20.TabIndex = 15;
            this.label20.Text = "Salary";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(70, 61);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(38, 17);
            this.label21.TabIndex = 14;
            this.label21.Text = "Year";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(46, 81);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 13;
            this.textBox6.Text = "0";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(46, 34);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 22);
            this.textBox7.TabIndex = 12;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(70, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(43, 17);
            this.label22.TabIndex = 11;
            this.label22.Text = "name";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(220, 252);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 24);
            this.button4.TabIndex = 8;
            this.button4.Text = "Добавить";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(220, 246);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(132, 24);
            this.button5.TabIndex = 9;
            this.button5.Text = "Добавить";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(223, 219);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 24);
            this.button2.TabIndex = 10;
            this.button2.Text = "Добавить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1461, 568);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.form1BindingSource1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource form1BindingSource;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource form1BindingSource1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Label2;
        private System.Windows.Forms.TextBox CompanyYear;
        private System.Windows.Forms.TextBox CompanyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox OwnerYear;
        private System.Windows.Forms.TextBox OwnerName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox OwnerBudget;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox ManagerExperience;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ManagerDepartment;
        private System.Windows.Forms.TextBox ManagerSalary;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ManagerYear;
        private System.Windows.Forms.TextBox ManagerName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox EngineerEquipment;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox EngineerDayOfHolidays;
        private System.Windows.Forms.TextBox EngineerSalary;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox EngineerYear;
        private System.Windows.Forms.TextBox EngineerName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox ManagerDayOfHolidays;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox CleanerNightShift;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button2;
    }
}

