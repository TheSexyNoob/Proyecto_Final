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
using GUI.Forms.Vehicule;
using GUI.Forms;

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
            this.Btn_CreateClients = new System.Windows.Forms.Button();
            this.UserLbl = new System.Windows.Forms.Label();
            this.Btn_SearchUser = new System.Windows.Forms.Button();
            this.Btn_SearchCompany = new System.Windows.Forms.Button();
            this.Btn_CreateVehicule = new System.Windows.Forms.Button();
            this.Btn_SearchVehicule = new System.Windows.Forms.Button();
            this.Btn_CreateCompany = new System.Windows.Forms.Button();
            this.Btn_CreateBill = new System.Windows.Forms.Button();
            this.Btn_SearchBill = new System.Windows.Forms.Button();
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
            this.Reports.Location = new System.Drawing.Point(471, 62);
            this.Reports.Name = "Reports";
            this.Reports.Size = new System.Drawing.Size(135, 47);
            this.Reports.TabIndex = 1;
            this.Reports.Text = "Reportes";
            this.Reports.UseVisualStyleBackColor = false;
            this.Reports.Click += new System.EventHandler(this.Reports_Click);
            // 
            // Btn_CreateClients
            // 
            this.Btn_CreateClients.BackColor = System.Drawing.Color.Chocolate;
            this.Btn_CreateClients.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_CreateClients.FlatAppearance.BorderSize = 0;
            this.Btn_CreateClients.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CreateClients.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_CreateClients.Location = new System.Drawing.Point(25, 225);
            this.Btn_CreateClients.Name = "Btn_CreateClients";
            this.Btn_CreateClients.Size = new System.Drawing.Size(135, 47);
            this.Btn_CreateClients.TabIndex = 2;
            this.Btn_CreateClients.Text = "Crear Usuarios.";
            this.Btn_CreateClients.UseVisualStyleBackColor = false;
            this.Btn_CreateClients.Click += new System.EventHandler(this.EmployeeBtn_Click);
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
            // Btn_SearchUser
            // 
            this.Btn_SearchUser.BackColor = System.Drawing.Color.Chocolate;
            this.Btn_SearchUser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_SearchUser.FlatAppearance.BorderSize = 0;
            this.Btn_SearchUser.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SearchUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_SearchUser.Location = new System.Drawing.Point(262, 225);
            this.Btn_SearchUser.Name = "Btn_SearchUser";
            this.Btn_SearchUser.Size = new System.Drawing.Size(135, 47);
            this.Btn_SearchUser.TabIndex = 7;
            this.Btn_SearchUser.Text = "Buscar Usuario.";
            this.Btn_SearchUser.UseVisualStyleBackColor = false;
            // 
            // Btn_SearchCompany
            // 
            this.Btn_SearchCompany.BackColor = System.Drawing.Color.Chocolate;
            this.Btn_SearchCompany.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_SearchCompany.FlatAppearance.BorderSize = 0;
            this.Btn_SearchCompany.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SearchCompany.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_SearchCompany.Location = new System.Drawing.Point(262, 291);
            this.Btn_SearchCompany.Name = "Btn_SearchCompany";
            this.Btn_SearchCompany.Size = new System.Drawing.Size(135, 47);
            this.Btn_SearchCompany.TabIndex = 8;
            this.Btn_SearchCompany.Text = "Buscar Empresa.";
            this.Btn_SearchCompany.UseVisualStyleBackColor = false;
            // 
            // Btn_CreateVehicule
            // 
            this.Btn_CreateVehicule.BackColor = System.Drawing.Color.Chocolate;
            this.Btn_CreateVehicule.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_CreateVehicule.FlatAppearance.BorderSize = 0;
            this.Btn_CreateVehicule.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CreateVehicule.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_CreateVehicule.Location = new System.Drawing.Point(27, 148);
            this.Btn_CreateVehicule.Name = "Btn_CreateVehicule";
            this.Btn_CreateVehicule.Size = new System.Drawing.Size(135, 47);
            this.Btn_CreateVehicule.TabIndex = 9;
            this.Btn_CreateVehicule.Text = "Crear Vehiculo";
            this.Btn_CreateVehicule.UseVisualStyleBackColor = false;
            this.Btn_CreateVehicule.Click += new System.EventHandler(this.Btn_CreateVehicule_Click);
            // 
            // Btn_SearchVehicule
            // 
            this.Btn_SearchVehicule.BackColor = System.Drawing.Color.Chocolate;
            this.Btn_SearchVehicule.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_SearchVehicule.FlatAppearance.BorderSize = 0;
            this.Btn_SearchVehicule.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SearchVehicule.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_SearchVehicule.Location = new System.Drawing.Point(262, 148);
            this.Btn_SearchVehicule.Name = "Btn_SearchVehicule";
            this.Btn_SearchVehicule.Size = new System.Drawing.Size(135, 47);
            this.Btn_SearchVehicule.TabIndex = 10;
            this.Btn_SearchVehicule.Text = "Buscar Vehiculo.";
            this.Btn_SearchVehicule.UseVisualStyleBackColor = false;
            // 
            // Btn_CreateCompany
            // 
            this.Btn_CreateCompany.BackColor = System.Drawing.Color.Chocolate;
            this.Btn_CreateCompany.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_CreateCompany.FlatAppearance.BorderSize = 0;
            this.Btn_CreateCompany.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CreateCompany.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_CreateCompany.Location = new System.Drawing.Point(25, 291);
            this.Btn_CreateCompany.Name = "Btn_CreateCompany";
            this.Btn_CreateCompany.Size = new System.Drawing.Size(135, 47);
            this.Btn_CreateCompany.TabIndex = 11;
            this.Btn_CreateCompany.Text = "Crear Empresa";
            this.Btn_CreateCompany.UseVisualStyleBackColor = false;
            this.Btn_CreateCompany.Click += new System.EventHandler(this.Btn_CreateCompany_Click);
            // 
            // Btn_CreateBill
            // 
            this.Btn_CreateBill.BackColor = System.Drawing.Color.Chocolate;
            this.Btn_CreateBill.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_CreateBill.FlatAppearance.BorderSize = 0;
            this.Btn_CreateBill.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_CreateBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_CreateBill.Location = new System.Drawing.Point(471, 148);
            this.Btn_CreateBill.Name = "Btn_CreateBill";
            this.Btn_CreateBill.Size = new System.Drawing.Size(135, 47);
            this.Btn_CreateBill.TabIndex = 12;
            this.Btn_CreateBill.Text = "Leer Codigo";
            this.Btn_CreateBill.UseVisualStyleBackColor = false;
            this.Btn_CreateBill.Click += new System.EventHandler(this.Btn_CreateBill_Click);
            // 
            // Btn_SearchBill
            // 
            this.Btn_SearchBill.BackColor = System.Drawing.Color.Chocolate;
            this.Btn_SearchBill.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Btn_SearchBill.FlatAppearance.BorderSize = 0;
            this.Btn_SearchBill.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_SearchBill.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Btn_SearchBill.Location = new System.Drawing.Point(471, 225);
            this.Btn_SearchBill.Name = "Btn_SearchBill";
            this.Btn_SearchBill.Size = new System.Drawing.Size(135, 47);
            this.Btn_SearchBill.TabIndex = 13;
            this.Btn_SearchBill.Text = "Generar Codigo Qr";
            this.Btn_SearchBill.UseVisualStyleBackColor = false;
            this.Btn_SearchBill.Click += new System.EventHandler(this.Btn_SearchBill_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScrollMargin = new System.Drawing.Size(700, 800);
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(618, 361);
            this.Controls.Add(this.Btn_SearchBill);
            this.Controls.Add(this.Btn_CreateBill);
            this.Controls.Add(this.Btn_CreateCompany);
            this.Controls.Add(this.Btn_SearchVehicule);
            this.Controls.Add(this.Btn_CreateVehicule);
            this.Controls.Add(this.Btn_SearchCompany);
            this.Controls.Add(this.Btn_SearchUser);
            this.Controls.Add(this.UserLbl);
            this.Controls.Add(this.Btn_CreateClients);
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

        private void Btn_CreateCompany_Click(object sender, EventArgs e)
        {
            CreateCompany company = new CreateCompany();
            company.Show();
        }

        private void Btn_CreateVehicule_Click(object sender, EventArgs e)
        {

            CreateVehicule vehicule = new CreateVehicule();
            vehicule.Show();

        }

        private void Btn_CreateBill_Click(object sender, EventArgs e)
        {

        }

        private void Btn_SearchBill_Click(object sender, EventArgs e)
        {
            QRgenerator.show();
        }
    }
}
