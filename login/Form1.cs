using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=JD\SQLSERVEREXPRESS;Initial Catalog=ejemplo;Integrated Security=True");

         public void logear(string usuario, string contrasena)
        {
          try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("select Nombre, Tipo_usuario from Usuarios where Usuario = @usuario and Password = @pass", con);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("pass", contrasena);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if (dt.Rows.Count == 1)
                {
                    this.Hide();
                    if (dt.Rows[0][1].ToString()=="Administrador")
                    {
                        new Administrador(dt.Rows[0][0].ToString()).Show();
                    }
                    else if(dt.Rows[0][1].ToString() == "Usuario")
                    {
                        new Usuario(dt.Rows[0][0].ToString()).Show();
                    }
                }
                else
                {
                    MessageBox.Show("usuario y/o contraseña inconrrectas");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            finally
            {
                con.Close();
            }
        } 

        private void button1_Click(object sender, EventArgs e)
        {
          logear(this.textBox1.Text, this.textBox2.Text);
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            logear(this.textBox1.Text, this.textBox2.Text);
        }
    }
}
