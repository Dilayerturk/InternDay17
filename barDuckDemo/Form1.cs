using EntityTest;
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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            Form2 openform2 = new Form2();
            openform2.Show();
            Visible = false;
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            Form2 openform2 = new Form2();
            openform2.Show();
            Visible = false;
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            Form2 openform2 = new Form2();
            openform2.Show();
            Visible = false;
        }
    }
}
