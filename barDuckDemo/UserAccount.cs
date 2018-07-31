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
    public partial class UserAccount : MetroFramework.Forms.MetroForm
    {
        public UserAccount()
        {
            InitializeComponent();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            PersonDbContext persondb = new PersonDbContext("Data Source=DESKTOP-37KIHLA\\SQLEXPRESS;Initial Catalog=UserDB;Integrated Security=True");
            Person person = new Person();
            person.Id = Guid.NewGuid();
            person.Name = txtName.Text;
            person.Age = cmbAge.SelectedItem.ToString();
            person.Gender = cmbGender.SelectedItem.ToString();

            var addedPerson = persondb.Persons.Add(person);
            persondb.SaveChanges();

            MessageBox.Show("Saved!");
            Form1 openform1 = new Form1();
            openform1.Show();
            this.Hide();
        }
    }
}
