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
using GUI.Forms.User;

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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ParkingBtn
            // 
            this.ParkingBtn.BackColor = System.Drawing.Color.Chocolate;
            this.ParkingBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ParkingBtn.FlatAppearance.BorderSize = 0;
            this.ParkingBtn.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ParkingBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.ParkingBtn.Location = new System.Drawing.Point(262, 62);
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
            this.Reports.Location = new System.Drawing.Point(80, 62);
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
            this.EmployeeBtn.Location = new System.Drawing.Point(25, 225);
            this.EmployeeBtn.Name = "EmployeeBtn";
            this.EmployeeBtn.Size = new System.Drawing.Size(135, 47);
            this.EmployeeBtn.TabIndex = 2;
            this.EmployeeBtn.Text = "Crear Usuarios.";
            this.EmployeeBtn.UseVisualStyleBackColor = false;
            this.EmployeeBtn.Click += new System.EventHandler(this.EmployeeBtn_Click);
            // 
            // UserLbl
            // 
            this.UserLbl.AutoSize = true;
            this.UserLbl.Location = new System.Drawing.Point(24, 25);
            this.UserLbl.Name = "UserLbl";
            this.UserLbl.Size = new System.Drawing.Size(32, 13);
            this.UserLbl.TabIndex = 3;
            this.UserLbl.Text = "User:";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Chocolate;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button4.Location = new System.Drawing.Point(262, 225);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(135, 47);
            this.button4.TabIndex = 7;
            this.button4.Text = "Buscar Usuario.";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Chocolate;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button5.Location = new System.Drawing.Point(262, 291);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 47);
            this.button5.TabIndex = 8;
            this.button5.Text = "Buscar Empresa.";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Chocolate;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button2.Location = new System.Drawing.Point(27, 148);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(135, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "Crear Vehiculo";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Chocolate;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(262, 148);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(135, 47);
            this.button3.TabIndex = 10;
            this.button3.Text = "Buscar Vehiculo.";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chocolate;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(25, 291);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Crear Empresa";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Chocolate;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button6.Location = new System.Drawing.Point(471, 148);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 47);
            this.button6.TabIndex = 12;
            this.button6.Text = "Factura";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Chocolate;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button7.Location = new System.Drawing.Point(471, 225);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(135, 47);
            this.button7.TabIndex = 13;
            this.button7.UseVisualStyleBackColor = false;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(700, 800);
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(618, 361);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
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
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void EmployeeBtn_Click(object sender, EventArgs e)
        {
            CreateClient client = new CreateClient();
            client.Show();
        }

        private void Reports_Click(object sender, EventArgs e)
        {
            ReportMenu reportMenu = new ReportMenu();
            reportMenu.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
