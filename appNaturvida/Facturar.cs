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
    public partial class Facturar : Form
    {
        string usuVen;

        public Facturar(string vend)
        {
            InitializeComponent();
            usuVen = vend;
        }

        #region "Objetos"
        Producto producto = new Producto();
        Factura factura = new Factura();
        Inventarios inventario = new Inventarios();
        DataSet informe = new DataSet();
        #endregion

        private void cargarComboBox()
        {
            cbCliente.DataSource = BaseDatos.cargarClientes();
            cbCliente.DisplayMember = "nombre";
            cbCliente.ValueMember = "identificacion";

            cbProducto.DataSource = BaseDatos.cargarProductos();
            cbProducto.DisplayMember = "descripcion";
            cbProducto.ValueMember = "codigo";

        }

        public void cargaProductosDataGrid()
        {
            try
            {
                informe = producto.mostrarDatos();
                Grid1.DataSource = informe;
                Grid1.DataMember = "Productos";

            }
            catch
            {
                MessageBox.Show(this.MdiParent, "Error al cargar el producto en la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Facturar_Load(object sender, EventArgs e)
        {
            cargarComboBox();
        }

        private void Grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grid1_SelectionChanged(object sender, EventArgs e)
        {

        }

        public void agregar()
        {
            try
            {

                string seleccion = cbProducto.SelectedValue.ToString();
                producto.Descripcion = seleccion;
                string cant = txtCantidad.Text;
                producto.Cantidad = Int32.Parse(cant);
                int numero = producto.Cantidad;
                informe = producto.mostrarProducto(seleccion);
                int cantidadEntradas = factura.mostrarCantidad(producto.Descripcion);
                int cantSalidas = factura.sumarCantidadEntrantes(seleccion);
                if (cantidadEntradas <= cantSalidas)
                {
                    MessageBox.Show(this.MdiParent, "La cantidad vendida es mayor que la cantidad existente del producto", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {

                    int num = Grid1.Rows.Add();
                    Grid1.Rows[num].Cells[0].Value = producto.Descripcion;
                    Grid1.Rows[num].Cells[1].Value = cbProducto.Text;
                    Grid1.Rows[num].Cells[2].Value = numero;
                    Grid1.Rows[num].Cells[3].Value = informe.Tables[0].Rows[0][0];

                }

            }
            catch
            {

                MessageBox.Show(this.MdiParent, "Error al agregar el producto a la factura", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void facturar()
        {
            try
            {

                int totalCantidad = 0;
                int totalValor = 0;

                foreach (DataGridViewRow dataGrid in Grid1.Rows)
                {
                    totalCantidad += Convert.ToInt16(dataGrid.Cells["Column3"].Value);
                    totalValor += Convert.ToInt16(dataGrid.Cells["Column4"].Value);
                }

                string valorTotal = Convert.ToString(totalCantidad * totalValor);

                txtTotalF.Text = valorTotal;

                factura.NumeroFactura = txtNumero.Text;
                factura.FechaFactura = dateTimePicker1.Value.Date.ToString("dd/MM/yyyy");
                factura.Cliente = cbCliente.SelectedValue.ToString();
                factura.ValorFactura = Convert.ToInt32(valorTotal);
                factura.Cantidad = Convert.ToInt32(txtCantidad.Text);
                factura.Vendedor = usuVen;

                foreach (DataGridViewRow dataGrid in Grid1.Rows)
                {

                    factura.Producto = Convert.ToString(dataGrid.Cells["Column1"].Value);
                    Console.WriteLine(factura.Producto.ToString());
                    if (factura.NumeroFactura == "" || factura.Producto == "" || factura.FechaFactura == "" || factura.Cliente == "" || valorTotal == "" || factura.Vendedor == "")
                    {
                        MessageBox.Show(this.MdiParent, "Debe digitar todos los campos", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else if (factura.insertar(factura.NumeroFactura, factura.Producto, factura.FechaFactura, factura.Cliente, factura.ValorFactura, factura.Vendedor, factura.Cantidad))
                    {

                    }
                }

                MessageBox.Show(this.MdiParent, "Factura generada exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {

                MessageBox.Show(this.MdiParent, "Factura No Ha sido Generada", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void limpiar()
        {
            txtNumero.Text = "";
            txtCantidad.Text = "";
            Grid1.Rows.Clear();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            agregar();
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            facturar();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }



    }
}
