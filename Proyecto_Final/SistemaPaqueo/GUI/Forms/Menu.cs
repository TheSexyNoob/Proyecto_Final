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
using ParkingServices;
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

        public void SetLabel(String Name)
        {
            UserLbl.Text += Name;
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.ParkingBtn = new System.Windows.Forms.Button();
            this.Reports = new System.Windows.Forms.Button();
            this.EmployeeBtn = new System.Windows.Forms.Button();
            this.UserLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ParkingBtn
            // 
            this.ParkingBtn.BackColor = System.Drawing.Color.Chocolate;
            this.ParkingBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ParkingBtn.FlatAppearance.BorderSize = 0;
            this.ParkingBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParkingBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ParkingBtn.Location = new System.Drawing.Point(148, 41);
            this.ParkingBtn.Name = "ParkingBtn";
            this.ParkingBtn.Size = new System.Drawing.Size(135, 47);
            this.ParkingBtn.TabIndex = 0;
            this.ParkingBtn.Text = "Parqueo";
            this.ParkingBtn.UseVisualStyleBackColor = false;
            this.ParkingBtn.Click += new System.EventHandler(this.ParkingBtn_Click_1);
            // 
            // Reports
            // 
            this.Reports.BackColor = System.Drawing.Color.Chocolate;
            this.Reports.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Reports.FlatAppearance.BorderSize = 0;
            this.Reports.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Reports.ForeColor = System.Drawing.Color.White;
            this.Reports.Location = new System.Drawing.Point(146, 111);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(135, 47);
            this.Reports.TabIndex = 1;
            this.Reports.Text = "Reportes";
            this.Reports.UseVisualStyleBackColor = false;
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // EmployeeBtn
            // 
            this.EmployeeBtn.BackColor = System.Drawing.Color.Chocolate;
            this.EmployeeBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.EmployeeBtn.FlatAppearance.BorderSize = 0;
            this.EmployeeBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.EmployeeBtn.Location = new System.Drawing.Point(146, 181);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.Size = new System.Drawing.Size(135, 47);
            this.EmployeeBtn.TabIndex = 2;
            this.EmployeeBtn.Text = "Usuarios";
            this.EmployeeBtn.UseVisualStyleBackColor = false;
            this.EmployeeBtn.Click += new System.EventHandler(this.EmployeeBtn_Click);
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Location = new System.Drawing.Point(12, 41);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(32, 13);
            this.UserLbl.TabIndex = 3;
            this.UserLbl.Text = "User:";
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(700, 800);
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(431, 361);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.EmployeeBtn);
            this.Controls.Add(this.Reports);
            this.Controls.Add(this.ParkingBtn);
            this.MaximumSize = new System.Drawing.Size(1024, 726);
            this.MinimumSize = new System.Drawing.Size(200, 400);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Menu_Load_1);
            this.ResumeLayout(false);
            this.PerformLayout();

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
