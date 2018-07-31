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
    public partial class Form2 : MetroFramework.Forms.MetroForm
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnAnswer1_Click(object sender, EventArgs e)
        {
            Form3 openform3 = new Form3();
            openform3.Show();
            Visible = false;
        }

        private void btnAnswer2_Click(object sender, EventArgs e)
        {
            Form3 openform3 = new Form3();
            openform3.Show();
            Visible = false;
        }

        private void btnAnswer3_Click(object sender, EventArgs e)
        {
            Form3 openform3 = new Form3();
            openform3.Show();
            Visible = false;
        }
    }
}
