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
    public partial class frmPrincipal : Form
    {
        string vend;

        public frmPrincipal()
        {
            InitializeComponent();
        }

        //llamar evento para abrir formulario dentro del menu principal
        private bool MostrarHijo(string NombreFormulario)
        {

            foreach (Form Elformulario in this.MdiChildren)
            {

                if (Elformulario.Name == NombreFormulario)
                {

                    Elformulario.Focus();
                    Elformulario.Show();
                    return true;
                }
            }

            return false;
        }

        //Boton Salir
        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea Salir de la aplicación?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes)
            {

                this.Close();
            }
        }

        //Menu Producto
        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MostrarHijo("FrmProductos") == true) return;
            Productos frmProductos = new Productos();
            frmProductos.Name = "FrmProductos";
            //frmProductos.MdiParent = this;
            frmProductos.Show();
        }

        //Menu Cliente
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MostrarHijo("FrmCliente") == true) return;
            Clientes frmCliente = new Clientes();
            frmCliente.Name = "FrmCliente";
            //frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        //Menu Factura
        private void facturarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MostrarHijo("FrmFactura") == true) return;
            Facturar frmFactura = new Facturar(vend);
            frmFactura.Name = "FrmFactura";
            //frmFactura.MdiParent = this;
            frmFactura.Show();
        }

        //Menu Inventario
        private void inventarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MostrarHijo("FrmInventario") == true) return;
            Inventario frmInventario = new Inventario();
            frmInventario.Name = "FrmInventario";
            //frmInventario.MdiParent = this;
            frmInventario.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }



        
    }
}
