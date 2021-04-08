using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appNaturvida
{
    public partial class Inventario : Form
    {
        public Inventario()
        {
            InitializeComponent();
        }

        #region "Objetos"
        Producto producto = new Producto();
        Factura factura = new Factura();
        Inventarios inventario = new Inventarios();
        #endregion

        #region "Variables"
        int entradas;
        #endregion

        public void cargaCombobox()
        {
            cbProducto.DataSource = BaseDatos.cargarProductos();
            cbProducto.DisplayMember = "descripcion";
            cbProducto.ValueMember = "codigo";
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            cargaCombobox();
        }

        private void cbProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            gridInventario.Rows.Clear();
            producto.Codigo = cbProducto.SelectedValue.ToString();
            producto.Descripcion = cbProducto.Text;
            entradas = factura.mostrarCantidad(producto.Codigo);
            Console.WriteLine(entradas);
            int cantidadSaliente = factura.sumarCantidadEntrantes(producto.Codigo);
            int cantidadDisponible = entradas - cantidadSaliente;

            int numero = gridInventario.Rows.Add();

            gridInventario.Rows[numero].Cells[0].Value = producto.Codigo;
            gridInventario.Rows[numero].Cells[1].Value = producto.Descripcion;
            gridInventario.Rows[numero].Cells[2].Value = entradas;
            gridInventario.Rows[numero].Cells[3].Value = cantidadSaliente;
            gridInventario.Rows[numero].Cells[4].Value = cantidadDisponible;
        }


    }
}
