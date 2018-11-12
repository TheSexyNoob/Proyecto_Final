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
    public partial class Form1 : Form
    {
        Utils utils;
        public Form1()
        {
            InitializeComponent();
             utils = new Utils();
        }
        public System.Drawing.Color BorderColor { get; set; }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Click Botones
        private void button1_Click(object sender, EventArgs e)
        {
            utils.BorderChange(botton1,this.dispo, placa,1);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void placa_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            utils.BorderChange(button2, disp2, placa2, 2);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            utils.BorderChange(button3, disp3, placa3, 3);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            utils.BorderChange(button4, disp4, placa4, 4);
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            utils.BorderChange(button5, disp5, placa5, 5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            utils.BorderChange(button6, disp6, placa6, 6);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
