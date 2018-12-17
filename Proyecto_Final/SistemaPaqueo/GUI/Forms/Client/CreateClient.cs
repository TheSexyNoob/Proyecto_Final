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

namespace GUI.Forms.User
{
    public partial class CreateClient : Form
    {
        public CreateClient()
        {
            InitializeComponent();
            RellenaCMB();
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Register_Click(object sender, EventArgs e)
        {
            ParkingServices.ParkingServices services = new ParkingServices.ParkingServices();
            if (FormIsComplete())
            {
                if (Code() != -1 || !Name().Equals("ERROR"))
                {
                    if (!services.ExistClient(Code()))
                    {
                        Client client = new Client(0, Code(), Name(), Company());
                        Console.Write(client.Company.ToString());
                        services.InsertClient(client);
                        Verifica(client.ClientId);
                    }
                    else
                    {
                        MessageBox.Show("¡El cliente con la cedula " + Code().ToString() + ", ya existe!");
                    }
                }
            }
            else
            {
                MessageBox.Show(@"Por favor completa los todos campos.");
            }
        }

        private void RellenaCMB()
        {
            ParkingServices.ParkingServices services = new ParkingServices.ParkingServices();
            Cmb_Company.Items.Clear();
            List<Company> _Company = services.GetCompanies();
            foreach(Company listArch in _Company)
            {
                Cmb_Company.Items.Add(listArch.ToString());
            }
        }

        public bool FormIsComplete()
        {
            if (!Txt_ID.Equals("") && !Txt_Name.Equals(""))
                return true;
            else
                return false;
        }

        public int Code()
        {
            int code;
            try
            {
                code = int.Parse(Txt_ID.Text.ToString());
            }
            catch (FormatException e)
            {
                MessageBox.Show(@"Error al ingresar el campo: Cedula.");
                code = -1;
            }
            return code;
        }

        public string Name()
        {
            string Nombre;
            if (!Txt_Name.Equals(""))
            {
                Nombre = Txt_Name.Text.ToString();
            }
            else
            {
                MessageBox.Show(@"Error al ingresar el campo: Nombre.");
                Nombre = "ERROR";
            }
            return Nombre;
        }

        public int Company()
        {
            return Cmb_Company.SelectedIndex + 1;
        }

        public void Verifica(int id)
        {
            ParkingServices.ParkingServices services = new ParkingServices.ParkingServices();
            if (services.ExistClient(id))
            {
                MessageBox.Show("Se ha ingresado correctamente.");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error.");
            }
        }
    }
}
