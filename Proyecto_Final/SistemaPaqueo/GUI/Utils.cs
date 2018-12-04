using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Base;


namespace GUI
{
    class Utils
    {

        BasedeDato basede = new BasedeDato();
        
        //static Boolean a = true;
        public Utils() { }
        
        public void BorderChange(Button btn, Label label,Label pla, int id)
        {
            string placa = null;

            if (basede.verifica(id))
            {
                bool a = false;

                while (!a)
                {
                    placa = Interaction.InputBox("Ingrese Numero de Placa", "Estacionamiento", "");//texto, titulo, PLACEHOLDER
                    a = Check(placa);
                }


                if (a)
                {
                    btn.FlatAppearance.BorderColor = System.Drawing.Color.Red;
                    label.Text = "Ocupado";
                    pla.Text = "Placa:"+placa;
                    string hora = DateTime.Now.ToString("h:mm:ss tt");
                    label.Text = hora;
                    pla.Visible = true;
                    MessageBox.Show(basede.Actualiza(id, false));
                    a = false;
                }


            }
            else
            {
                DialogResult resultado = MessageBox.Show("Vehiculo sale?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information); 
                if (resultado == DialogResult.Yes)
                {
                    MessageBox.Show(basede.Sale(id));
                    btn.FlatAppearance.BorderColor = System.Drawing.Color.Green;
                    label.Text = "Disponible";
                    pla.Text = null;
                    pla.Visible = false;
                    
                }
                else
                {
                    
                }
            }
        }


        public bool Check(String data)
        {
            if (String.IsNullOrEmpty(data))
            {
                MessageBox.Show("Ingrese La placa");
                return false;
            }
            else {
                if (data.Length < 6 || data.Length > 6)
                {
                    MessageBox.Show("La Placa debe tener 6 caracteres");
                    return false;
                }
                else {
                    string pattern = "[a-zA-Z0-9]";
                    if (System.Text.RegularExpressions.Regex.IsMatch(data, pattern))
                    {
                        return true;
                    }
                    else {
                        MessageBox.Show("Ingrese solo numeros y letras");
                        return false; 
                    }
                }
            }
        }

        public string VerifyPlate(string plate)
        {
            /*if (findData==true) {
                return "License Plate already in the system";
            }
            else{
                return "ok";
            }*/
            return "";
        }

    }
}
