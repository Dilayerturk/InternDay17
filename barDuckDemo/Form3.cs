using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barDuckDemo
{
    public partial class Form3 : MetroFramework.Forms.MetroForm
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void btnQr_Click(object sender, EventArgs e)
        {
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox1.Image=qrcode.Draw(lblArza.Text, 50);
        }

        private void btn_Location_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder queryaddress = new StringBuilder();
                queryaddress.Append("https://www.google.com/maps/place/Arza+Bar/@41.0347665,28.9804289,17z/data=!3m1!4b1!4m5!3m4!1s0x14cab763f9cae927:0xc0c8b41b4d398e85!8m2!3d41.0347665!4d28.9826176");
                webBrowser1.Navigate(queryaddress.ToString());
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "ERROR");
            }
        }
    }
}
