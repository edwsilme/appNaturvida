using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appNaturvida
{
    class Producto
    {

        #region "Objetos"
        BaseDatos bd = new BaseDatos();
        DataSet data = new DataSet();
        #endregion

        #region "Atributos"
        string codigo;
        string descripcion;
        int valor;
        int cantidad;
        #endregion

        #region "Propiedades"

        public string Codigo
        {
            set { codigo = value; }
            get { return codigo; }
        }

        public string Descripcion
        {
            set { descripcion = value; }
            get { return descripcion; }
        }

        public int Valor
        {
            set { valor = value; }
            get { return valor; }
        }

        public int Cantidad
        {
            set { cantidad = value; }
            get { return cantidad; }
        }

        #endregion

        #region "Funciones DML"

        public bool insertar(string codigo, string descripcion, int valor, int cantidad)
        {
            string sql = "INSERT INTO Productos(proCodigo,proDescripcion,proValor,proCantidad)" +
                "values('" + codigo + "','" + descripcion + "'," + valor + "," + cantidad + ")";
            return bd.ejecutarSentenciaDML(sql);
        }

        public bool eliminar(string codigo)
        {
            string sql = "DELETE FROM Productos WHERE proCodigo='" + codigo + "'";
            return bd.ejecutarSentenciaDML(sql);
        }

        public bool modificar(string codigo, string descripcion, int valor, int cantidad)
        {
            string sql = "UPDATE Productos " +
                "SET proCodigo='" + codigo + "'," +
                "proDescripcion='" + descripcion + "'," +
                "proValor=" + valor + "," +
                "proCantidad=" + cantidad + "," +
                "WHERE proCodigo='" + codigo + "'";
            return bd.ejecutarSentenciaDML(sql);
        }

        public DataSet consultar(string codigo)
        {
            string consultaSQL = "SELECT * FROM Productos WHERE proCodigo='" + codigo + "'";
            return bd.ejecutarComando(consultaSQL, "Productos");
        }

        public DataSet mostrarProducto(String codigo)
        {
            string consultaSQL = "SELECT proCodigo as Codigo, proDescripcion as Descripcion, proCantidad as Cantidad," + 
                "proValor as Valor FROM Productos WHERE proCodigo='" + Codigo +"'";
            return bd.ejecutarComando(consultaSQL, "Productos");
        }

        public DataSet mostrarDatos()
        {
            string consultaSQL = "SELECT proCodigo as Codigo, proDescripcion as Descripcion, proCantidad as Cantidad," +
                "proValor as Valor FROM Productos";
            return bd.ejecutarComando(consultaSQL, "Productos");
        }

        public DataSet mostrarReportes()
        {
            string consultaSQL = "SELECT * FROM Productos";
            return bd.ejecutarComando(consultaSQL, "Productos");
        }

        public DataSet cargarCodigosProducto()
        {
            string consultaSQL = "SELECT proCodigo FROM Productos";
            return bd.ejecutarComando(consultaSQL, "Productos");
        }

        #endregion
    }
}
