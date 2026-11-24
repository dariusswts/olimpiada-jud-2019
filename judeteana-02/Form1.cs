using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace judeteana_02
{
    public partial class AutentificareForm : Form
    {
        public AutentificareForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string parola = txtParola.Text;

            bool gasit = false;

            string[] linii = System.IO.File.ReadAllLines("Utilizatori.txt");

            foreach (string linie in linii)
            {
                string[] v = linie.Split('#');

                if (v.Length == 4)
                {
                    if (v[2] == email && v[3] == parola)
                    {
                        gasit = true;

                        SpiralaForm f = new SpiralaForm(email);
                        f.ShowDialog();

                        break;
                    }
                }
            }

            if (gasit == false)
            {
                MessageBox.Show("Email sau parola gresita!");

                txtEmail.Clear();
                txtParola.Clear();

                txtEmail.Focus();
            }
        }
    }
}
