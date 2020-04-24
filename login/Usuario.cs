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
using MetroFramework.Forms;

namespace login
{
    public partial class Usuario : MetroForm
    {
        public Usuario(string nombre)
        {
            InitializeComponent();

            lblMensajeAdmin.Text = "Bienvenido " + nombre;
        }

        SqlCommand comando = new SqlCommand();

        DataSet resultados = new DataSet();
        DataView mifiltro;

        private void leer_datos(string query, ref DataSet dstprincipal, string tabla)
        {
            try
            {
                string cadena = "Data Source=JD\\SQLSERVEREXPRESS;Database=ejemplo;Integrated Security=true";
                //  SqlConnection con = new SqlConnection(@"Data Source=JD\SQLSERVEREXPRESS;Initial Catalog=dbBiblioteca;Integrated Security=True");
                SqlConnection cn = new SqlConnection(cadena);
                SqlCommand cmd = new SqlCommand(query, cn);
                cn.Open();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dstprincipal, tabla);
                da.Dispose();
                cn.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void Usuario_Load(object sender, EventArgs e)
        {
            //mostrar();
            this.leer_datos("select *from Productos", ref resultados, "Productos");
            this.mifiltro = ((DataTable)resultados.Tables["Productos"]).DefaultView;
            this.dgvLibro.DataSource = mifiltro;
        }

        /*private void bunifuTextbox1_KeyUp(object sender, EventArgs e)
        {
            string salida_datos = "";
            string[] palabras_busqueda = this.bunifuTextbox1.text.Split(' ');
            foreach (string palabra in palabras_busqueda)
            {
                if (salida_datos.Length == 0)
                {
                    salida_datos = "(NomProducto like'%" + palabra + "%' or Grupo like'%" + palabra + "%' or Precio like'%')";
                }
                else
                {
                    salida_datos += "AND(NomProducto like'%" + palabra + "%' or Grupo like'%" + palabra + "%' or Precio like'%')";
                }
            }
            this.mifiltro.RowFilter = salida_datos;
        }*/
    }
}
