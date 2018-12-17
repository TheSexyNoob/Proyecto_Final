using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using ParkingServices;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            ParkingServices.ParkingServices services = new ParkingServices.ParkingServices();
            if (FormIsComplete())
            {
                if(Code() != -1 || !Password().Equals("ERROR"))
                {
                    if(services.AdminChecker(Code(), Password()))
                    {
                        string name = services.GetAdmin(Code()).Name;
                        MessageBox.Show("Bienvenid@.");
                        Menu menu = new Menu();
                        this.Hide();
                        menu.SetLabel(name);
                        menu.Show();
                    }
                    else
                    {
                        MessageBox.Show("Verifique su codigo y/o contraseña e intentelo de nuevo...");
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Por favor completa los todos campos.");
            }
        }
        
        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool FormIsComplete()
        {
            if (!Txt_Code.Equals("") && !Txt_Password.Equals(""))
                return true;
            else
                return false;
        }

        public int Code()
        {
            int code;
            try
            {
                code = int.Parse(Txt_Code.Text.ToString());
            }
            catch (FormatException e)
            {
                MessageBox.Show(@"Error al ingresar el campo: Codigo.");
                code = -1;
            }
            Console.Write("Dato devuelto : {0}", code);
            return code;
        }

        public string Password()
        {
            string password;
            if (!Txt_Password.Equals(""))
            {
                password = Txt_Password.Text.ToString();
            }
            else
            {
                MessageBox.Show(@"Error al ingresar el campo: Contraseña.");
                password = "ERROR";
            }
            return password;
        }
    }
}
