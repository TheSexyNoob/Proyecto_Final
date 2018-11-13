using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image img = (Image)qrCodeImgControl1.Image.Clone();

            SaveFileDialog sfl = new SaveFileDialog();
            sfl.AddExtension = true;
            sfl.Filter = "Image JPG(*.jpg)|*.jpg";
            sfl.ShowDialog();
            if (!string.IsNullOrEmpty(sfl.FileName))
            {
                img.Save(sfl.FileName);
                textBox1.Text=null;
            }
            img.Dispose();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            qrCodeImgControl1.Text = textBox1.Text;
            

        }
    }
}
