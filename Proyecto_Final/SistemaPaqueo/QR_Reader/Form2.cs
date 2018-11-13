using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using BarcodeLib.BarcodeReader;


namespace QR_Reader
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private FilterInfoCollection User;
        private VideoCaptureDevice WebCam;
        private void Form2_Load(object sender, EventArgs e)
        {
            //LISTAR DISPOSITIVOS DE ENTRADA DE VIDEO
            User = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            //CARGAR TODOS LOS DISPOSITIVOS AL COMBO
            foreach (FilterInfo x in User)
            {
                comboBox1.Items.Add(x.Name);
            }
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            WebCam = new VideoCaptureDevice(User[comboBox1.SelectedIndex].MonikerString);
            videoSourcePlayer1.VideoSource = WebCam;
            videoSourcePlayer1.Start();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            videoSourcePlayer1.SignalToStop();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (videoSourcePlayer1.GetCurrentVideoFrame() != null)
            {
                Bitmap img = new Bitmap(videoSourcePlayer1.GetCurrentVideoFrame());
                string[] Info = BarcodeReader.read(img, BarcodeReader.QRCODE);
                img.Dispose();
                if (Info != null && Info.Count()>0)
                {
                    listBox1.Items.Add(Info[0]);                }
            }
        }
    }
}
