using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appNaturvida
{
    class Cliente
    {

        #region "Objetos"
        BaseDatos bd = new BaseDatos();
        DataSet data = new DataSet();
        #endregion

        #region "Atributos"
        string identificacion;
        string nombre;
        string direccion;
        string telefono;
        string correo;
        #endregion

        #region "Propiedades"

        public string Identificacion
        {
            set { identificacion = value; }
            get { return identificacion; }
        }

        public string Nombre
        {
            set { nombre = value; }
            get { return nombre; }
        }

        public string Direccion
        {
            set { direccion = value; }
            get { return direccion; }
        }

        public string Telefono
        {
            set { telefono = value; }
            get { return telefono; }
        }

        public string Correo
        {
            set { correo = value; }
            get { return correo; }
        }

        #endregion

        #region "Funciones DML"

        public bool insertar(string identificacion, string nombre, string direccion, string telefono, string correo)
        {
            string sql = "INSERT INTO Clientes(cliDocumento,cliNombre,cliDireccion,cliTelefono,cliCorreo)" +
                "values('" + identificacion + "','" + nombre + "','" + direccion + "','" + telefono + "','" + correo + "')";
            return bd.ejecutarSentenciaDML(sql);
        }

        public bool eliminar(string identificacion)
        {
            string sql = "DELETE FROM Clientes WHERE cliDocumento='" + identificacion + "'";
            return bd.ejecutarSentenciaDML(sql);
        }

        public bool modificar(string identificacion, string nombre, string direccion, string telefono, string correo)
        {
            string sql = "UPDATE Clientes " +
                "SET cliDocumento='" + identificacion + "'," +
                "cliNombre='" + nombre + "'," +
                "cliDireccion='" + direccion + "'," +
                "cliTelefono='" + telefono + "'," +
                "cliCorreo='" + correo + "' " +
                "WHERE cliDocumento='" + identificacion + "'";
            return bd.ejecutarSentenciaDML(sql);
        }

        public DataSet consultar(string identificacion)
        {
            string consultaSQL = "SELECT * FROM Clientes WHERE cliDocumento='" + identificacion + "'";
            return bd.ejecutarComando(consultaSQL, "Clientes");
        }

        public DataSet mostrarConsulta(String identificacion)
        {
            string consultaSQL = "SELECT cliDocumento as Identificacion, cliNombre as Nombre," +
                "cliDireccion as Direccion, cliTelefono as telefono, cliCorreo as Correo FROM Clientes WHERE cliDocumento='" + identificacion + "'";
            return bd.ejecutarComando(consultaSQL, "Clientes");
        }

        public DataSet mostrarDatos()
        {
            string consultaSQL = "SELECT cliDocumento as Identificacion, cliNombre as Nombre," +
                "cliDireccion as Direccion, cliTelefono as telefono, cliCorreo as Correo FROM Clientes";
            return bd.ejecutarComando(consultaSQL, "Clientes");
        }

        public DataSet mostrarReportes()
        {
            string consultaSQL = "SELECT * FROM Clientes";
            return bd.ejecutarComando(consultaSQL, "Clientes");
        }

        public DataSet cargarCodigosClientes()
        {
            string consultaSQL = "SELECT cliDocumento FROM Clientes";
            return bd.ejecutarComando(consultaSQL, "Clientes");
        }

        #endregion
    }
}
