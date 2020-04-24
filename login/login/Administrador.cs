using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class Administrador : Form
    {
        public Administrador(string nombre)
        {
            InitializeComponent();
            lblMensajeAdmin.Text = "Bienvenido "+nombre;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
          //  Form1 frm1 = new Form1();
           // frm1.Show();

            new Form1().Show();
        }
    }
}
