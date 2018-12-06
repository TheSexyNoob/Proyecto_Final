using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class CreateUserMenu : Form
    {
        public CreateUserMenu()
        {
            InitializeComponent();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu mainMenu = new Menu();
            mainMenu.ShowDialog();
        }

        private void applyBtn_Click(object sender, EventArgs e)
        {
            //Applies all the changes to the specific user, if the user is not created, it will automatically
            Vehicule vehicule = new Vehicule();
            

            vehicule.Colour = colourTxt.Text;
            vehicule.Description = descriptionTxt.Text;
            vehicule.LicensePlate = licensePlateTxt.Text;
            vehicule.Model = modelTxt.Text;
            vehicule.Type = vehiculeComboBox.Text;
            Client client = new Client(Int32.Parse(employeeNumberTxt.Text), Int32.Parse(IdTxt.Text),nameTxt.Text,companyTxt.Text,vehicule);
            //Console.WriteLine(client.ToString());
            MessageBox.Show(client.ToString());

            /*if(findUser method==false){
                createUser method
            }else{
                modifyUser method
            }*/

        }

        private void okBtn_Click(object sender, EventArgs e)
        {
            //verify changes
            //save changes
            this.Hide();
            Menu menu = new Menu();
            menu.ShowDialog();
        }

        private void nameTxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            //find user
            //if(findUser==true){
            Client client = new Client(); //Users information
         
            nameTxt.Text = client.Name;
            companyTxt.Text = client.Company;
            employeeNumberTxt.Text = client.code.ToString();
            IdTxt.Text = client.Id.ToString();
            colourTxt.Text = client.vehicule.Colour;
            modelTxt.Text = client.vehicule.Model;
            vehiculeComboBox.Text = client.vehicule.Type;
            descriptionTxt.Text = client.vehicule.Description;
            licensePlateTxt.Text = client.vehicule.LicensePlate;

            //}else {infoLbl.Text = "User was not found";}
        }
    }
}
