using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySql.Data.Types;


namespace appNaturvida
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //Conexion con la base de datos
            SqlConnection conectar = new SqlConnection("Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=bdNaturvida;Integrated Security=True");
            conectar.Open();

            SqlCommand codigo = new SqlCommand();
            SqlConnection acceso = new SqlConnection();
            codigo.Connection = conectar;

            //Conexion a la tabla Vendedores de la BD NaturVida
            codigo.CommandText = ("Select * from Vendedores where venUsuario = '" + txtUser.Text + "' and venContrasena = '" + txtPass.Text + "' ");

            SqlDataReader leer = codigo.ExecuteReader();

            if (leer.Read())
            {

                MessageBox.Show("Bienvenido");
                frmPrincipal abrir = new frmPrincipal(); //Abre la ventana menu principal
                abrir.Show();
                this.Hide();
            }
            else
            {

                MessageBox.Show("Usuario y/o contraseña no son correctos");
            }

            conectar.Close();
        }


    }
}
