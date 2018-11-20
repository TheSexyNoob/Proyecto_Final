using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace GUI
{
    public partial class Menu : Form
    {
        MainMenu menu;
        public Menu()
        {
            InitializeComponent();

            menu = new MainMenu();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }


        private void InitializeComponent()
        {
            this.ParkingBtn = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.Button();
            this.EmployeeBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ParkingBtn
            // 
            this.ParkingBtn.Location = new System.Drawing.Point(148, 41);
            this.ParkingBtn.Name = "ParkingBtn";
            this.ParkingBtn.Size = new System.Drawing.Size(135, 47);
            this.ParkingBtn.TabIndex = 0;
            this.ParkingBtn.Text = "Parqueo";
            this.ParkingBtn.UseVisualStyleBackColor = true;
            this.ParkingBtn.Click += new System.EventHandler(this.ParkingBtn_Click_1);
            // 
            // Reports
            // 
            this.Reports.Location = new System.Drawing.Point(146, 111);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(135, 47);
            this.Reports.TabIndex = 1;
            this.Reports.Text = "Reportes";
            this.Reports.UseVisualStyleBackColor = true;
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // EmployeeBtn
            // 
            this.EmployeeBtn.Location = new System.Drawing.Point(146, 181);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.Size = new System.Drawing.Size(135, 47);
            this.EmployeeBtn.TabIndex = 2;
            this.EmployeeBtn.Text = "Usuarios";
            this.EmployeeBtn.UseVisualStyleBackColor = true;
            this.EmployeeBtn.Click += new System.EventHandler(this.EmployeeBtn_Click);
            // 
            // Menu
            // 
            this.ClientSize = new System.Drawing.Size(436, 264);
            this.Controls.Add(this.EmployeeBtn);
            this.Controls.Add(this.Reports);
            this.Controls.Add(this.ParkingBtn);
            this.Name = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load_1);
            this.ResumeLayout(false);

        }

        private void Menu_Load_1(object sender, EventArgs e)
        {

        }

        private void ParkingBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateUserMenu userMenu = new CreateUserMenu();
            userMenu.ShowDialog();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            this.Hide();
            ReportMenu reportMenu = new ReportMenu();
            reportMenu.ShowDialog();
        }
    }
}
