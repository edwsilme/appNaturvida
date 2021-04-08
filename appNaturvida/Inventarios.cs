using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace appNaturvida
{
    class Inventarios
    {
        #region "Objetos"
        BaseDatos bd = new BaseDatos();
        DataSet data = new DataSet();
        #endregion

        #region"Atributos"
        string codigoInventario;
        string codigoProducto;
        int entrada;
        int salida;
        int disponible;
        #endregion

        #region "Propiedades"

        public string CodigoInventario
        {
            set { codigoInventario = value; }
            get { return codigoInventario; }
        }

        public string CodigoProducto
        {
            set { codigoProducto = value; }
            get { return codigoProducto; }
        }

        public int Entrada
        {
            set { entrada = value; }
            get { return entrada; }
        }

        public int Salida
        {
            set { salida = value; }
            get { return salida; }
        }

        public int Disponible
        {
            set { disponible = value; }
            get { return disponible; }
        }
        #endregion

        #region "Metodos DML"

        public bool insertar(string codigoProducto, int entradas, int salidas, int disponibles)
        {
            string sql = "insert into Inventario(prodInventario,entradas,salidas,disponibles)" +
                "values('" + codigoProducto + "'," + entradas + "," + salidas + "," + disponibles + ")";
            return bd.ejecutarSentenciaDML(sql);
        }

        public void limpiar(string campo1, string campo2, string campo3, string campo4, string campo5)
        {
            campo1 = "";
            campo2 = "";
            campo3 = "";
            campo4 = "";
            campo5 = "";
        }

        #endregion
    }
}
