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
    public partial class SpiralaForm : Form
    {

        public SpiralaForm(string email)
        {
            InitializeComponent();

            lblEmail.Text = email;

            txtNumar.Text = "17";

            chkMargini.Checked = true;
            chkUmplere.Checked = false;
            chkEtichete.Checked = false;

            pictureBox1.BackColor = Color.White;
        }

        
    }
}
