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

namespace GUI.Forms.Vehicule
{
    public partial class CreateVehicule : Form
    {
        public CreateVehicule()
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
                if (!Plate().Equals("ERROR"))
                {
                    if (!services.ExistVehicule(Plate()))
                    {
                        Entities.Vehicule vehicule = new Entities.Vehicule(0, Plate(), Txt_Colour.Text.ToString(), Txt_Model.Text.ToString(), Type(), Txt_Description.Text.ToString());
                        Console.Write(vehicule.ToString());
                        services.InsertVehicule(vehicule);
                        Verifica(vehicule.LicensePlate);
                    }
                    else
                    {
                        MessageBox.Show("¡El vehiculo con la placa " + Plate().ToString() + ", ya existe!");
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
            Cmb_Type.Items.Clear();
            List<TypeVehicule> _Types = services.GetTypeVehicule();
            foreach (TypeVehicule listArch in _Types)
            {
                Cmb_Type.Items.Add(listArch.ToString());
            }
        }

        public bool FormIsComplete()
        {
            if (!Txt_Plate.Equals("") && (Type()-1) == 0)
                return true;
            else
                return false;
        }

        public string Plate()
        {
            string Nombre;
            if (!Txt_Plate.Equals(""))
            {
                Nombre = Txt_Plate.Text.ToString();
            }
            else
            {
                MessageBox.Show(@"Error al ingresar el campo: Nombre.");
                Nombre = "ERROR";
            }
            return Nombre;
        }

        public int Type()
        {
            return Cmb_Type.SelectedIndex + 1;
        }

        public void Verifica(string plate)
        {
            ParkingServices.ParkingServices services = new ParkingServices.ParkingServices();
            if (services.ExistVehicule(plate))
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
