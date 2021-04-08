using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
using System.Collections;


namespace appNaturvida
{
    class BaseDatos
    {

        Int32 cantidad;
        public DataSet ejecutarComando(string sql, string nombreTabla)
        {
            string comandoConexion = "Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=bdNaturvida;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(comandoConexion);
            DataSet datos = new DataSet();
            SqlDataAdapter adaptador = new SqlDataAdapter(sql, conexion);
            adaptador.Fill(datos, nombreTabla);
            return datos;
        }

        public bool ejecutarSentenciaDML(String DML)
        {

            string comandoConexion = "Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=bdNaturvida;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(comandoConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand(DML, conexion);
            if (comando.ExecuteNonQuery() > 0)
            {
                return true;
            }
            else
                return false;
        }

        public int obtenerCantidad(string DML)
        {
            string comandoConexion = "Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=bdNaturvida;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(comandoConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand(DML, conexion);
            cantidad = (Int32)(comando.ExecuteScalar());
            return cantidad;
        }


        public static List<Producto> cargarProductos()
        {
            List<Producto> listaProductos = new List<Producto>();
            string comandoConexion = "Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=bdNaturvida;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(comandoConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT proCodigo, proDescripcion FROM Productos", conexion);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Producto unProducto = new Producto();

                unProducto.Codigo = lector.GetString(0);
                unProducto.Descripcion = lector.GetString(1);

                listaProductos.Add(unProducto);
            }

            return listaProductos;
        }

        public static List<classID> cargarTipoID()
        {
            List<classID> listaTipoID = new List<classID>();
            string comandoConexion = "Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=bdNaturvida;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(comandoConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("select codigoID,tipoDocumento from tipoID", conexion);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                classID tipoID = new classID();

                tipoID.CodigoID = lector.GetString(0);
                tipoID.ID = lector.GetString(1);

                listaTipoID.Add(tipoID);
            }

            return listaTipoID;
        }

        public static List<Cliente> cargarClientes()
        {
            List<Cliente> listaClientes = new List<Cliente>();
            string comandoConexion = "Data Source=USUARIO-PC\\SQLEXPRESS;Initial Catalog=bdNaturvida;Integrated Security=True";
            SqlConnection conexion = new SqlConnection(comandoConexion);
            conexion.Open();
            SqlCommand comando = new SqlCommand("SELECT cliDocumento, cliNombre FROM Clientes", conexion);
            SqlDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                Cliente unCliente = new Cliente();

                unCliente.Identificacion = lector.GetString(0);
                unCliente.Nombre = lector.GetString(1);

                listaClientes.Add(unCliente);
            }

            return listaClientes;
        }

    }
}
