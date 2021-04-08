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
    public partial class Productos : Form
    {

        public Productos()
        {
            InitializeComponent();
        }

        #region "Objetos"
        Producto producto = new Producto();
        DataSet informe = new DataSet();
        #endregion


        public void cargaCombobox()
        {
            cb1Consultar.DataSource = BaseDatos.cargarProductos();
            cb1Consultar.DisplayMember = "descripcion";
            cb1Consultar.ValueMember = "codigo";

            cb2Modificar.DataSource = BaseDatos.cargarProductos();
            cb2Modificar.DisplayMember = "descripcion";
            cb2Modificar.ValueMember = "codigo";

            cb3Eliminar.DataSource = BaseDatos.cargarProductos();
            cb3Eliminar.DisplayMember = "descripcion";
            cb3Eliminar.ValueMember = "codigo";
        }

        public void cargaConsulta(string codigo)
        {
            informe = producto.consultar(codigo);
            GridDatos.DataSource = informe;
            GridDatos.DataMember = "Productos";
        }

        public void cargaBuscar(String pr)
        {
            informe = producto.mostrarProducto(pr);
            GridDatos.DataSource = informe;
            GridDatos.DataMember = "Productos";
        }

        public void cargaDatos()
        {
            informe = producto.mostrarDatos();
            GridDatos.DataSource = informe;
            GridDatos.DataMember = "Productos";
        }

        private void Productos_Load(object sender, EventArgs e)
        {

            cargaCombobox();
        }

        private void GridDatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridDatos_SelectionChanged(object sender, EventArgs e)
        {

        }

        public void limpiar()
        {
            txt1Codigo.Text = "";
            txt2Descripcion.Text = "";
            txt3Valor.Text = "";
            txt4Cantidad.Text = "";
        }

        public void guardar()
        {
            producto.Codigo = txt1Codigo.Text;
            producto.Descripcion = txt2Descripcion.Text;
            producto.Valor = Convert.ToInt32(txt3Valor.Text);
            producto.Cantidad = Convert.ToInt32(txt4Cantidad.Text);


            try
            {
                if (txt1Codigo.Text == "" || txt2Descripcion.Text == "" || txt3Valor.Text == "" || txt4Cantidad.Text == "")
                    MessageBox.Show(this.MdiParent, "Debe digitar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (producto.insertar(producto.Codigo, producto.Descripcion, producto.Valor, producto.Cantidad))
                {
                    MessageBox.Show(MdiParent, "Producto Ingresado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargaCombobox();
                }
            }
            catch
            {

                MessageBox.Show(MdiParent, "Producto No ingresado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void consultar()
        {
            try
            {
                string seleccion = cb1Consultar.SelectedValue.ToString();
                cargaBuscar(seleccion);

            }
            catch
            {
                MessageBox.Show(this.MdiParent, "Error al momento de buscar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void modificar()
        {
            try
            {
                string seleccion = cb2Modificar.SelectedValue.ToString();
                informe = producto.consultar(seleccion);
                txt5Codigo.Text = informe.Tables["Productos"].Rows[0]["proCodigo"].ToString();
                txt6Descripcion.Text = informe.Tables["Productos"].Rows[0]["proDescripcion"].ToString();
                txt7Valor.Text = informe.Tables["Productos"].Rows[0]["proValor"].ToString();
                txt8Cantidad.Text = informe.Tables["Productos"].Rows[0]["proCantidad"].ToString();

            }
            catch
            {

                MessageBox.Show(MdiParent, "Error al momento de buscar el producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void guardaCambios()
        {
            try
            {
                producto.Codigo = txt5Codigo.Text;
                producto.Descripcion = txt6Descripcion.Text;
                producto.Valor = Convert.ToInt32(txt7Valor.Text);
                producto.Cantidad = Convert.ToInt32(txt8Cantidad.Text);


                if (producto.Codigo == "" || producto.Descripcion == "" || txt7Valor.Text == "" || txt8Cantidad.Text == "")
                {
                    MessageBox.Show(this.MdiParent, "Debe llenar todos los espacios", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (producto.modificar(producto.Codigo, producto.Descripcion, producto.Valor, producto.Cantidad))
                {
                    MessageBox.Show(this.MdiParent, "Producto Modificado Correctamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargaDatos();
                    cargaCombobox();
                }

            }
            catch
            {
                MessageBox.Show(this.MdiParent, "Datos no modificados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void eliminar()
        {
            try
            {
                string seleccion = cb3Eliminar.SelectedValue.ToString();
                producto.eliminar(seleccion);
                cargaCombobox();

                MessageBox.Show(this.MdiParent, "Producto Eliminado Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {

                MessageBox.Show(this.MdiParent, "Producto No Eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn1Guardar_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void tn3Consultar_Click(object sender, EventArgs e)
        {
            consultar();
        }

        private void btn4Modificar_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void btn5GCambios_Click(object sender, EventArgs e)
        {
            guardaCambios();
        }

        private void btn6Eliminar_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void btn2Limpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txt1Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt3Valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt4Cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb1Consultar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cb2Modificar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt5Codigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt6Descripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt7Valor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt8Cantidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void cb3Eliminar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
