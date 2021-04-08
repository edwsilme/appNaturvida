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
    public partial class Clientes : Form
    {

        public Clientes()
        {
            InitializeComponent();
        }

        #region "Objetos"
        Cliente cliente = new Cliente();
        DataSet informe = new DataSet();
        #endregion


        public void cargaComboBox()
        {
            cboxConsultar.DataSource = BaseDatos.cargarClientes();
            cboxConsultar.DisplayMember = "nombre";
            cboxConsultar.ValueMember = "identificacion";

            cboxModificar.DataSource = BaseDatos.cargarClientes();
            cboxModificar.DisplayMember = "nombre";
            cboxModificar.ValueMember = "identificacion";

            cboxEliminar.DataSource = BaseDatos.cargarClientes();
            cboxEliminar.DisplayMember = "nombre";
            cboxEliminar.ValueMember = "identificacion";
        }

        public void cargaConsulta(string codigo)
        {
            informe = cliente.consultar(codigo);
            GridDatos1.DataSource = informe;
            GridDatos1.DataMember = "Clientes";
        }

        public void cargaBuscar(String id)
        {
            informe = cliente.mostrarConsulta(id);
            GridDatos1.DataSource = informe;
            GridDatos1.DataMember = "Clientes";
        }

        public void cargaDatos()
        {
            informe = cliente.mostrarDatos();
            GridDatos1.DataSource = informe;
            GridDatos1.DataMember = "Clientes";
        }

        private void Clientes_Load(object sender, EventArgs e)
        {

            cargaComboBox();
        }

        private void GridDatos1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GridDatos1_SelectionChanged(object sender, EventArgs e)
        {

        }

        public void limpiar()
        {
            txtIdentificacion.Text = "";
            txtNombres.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
        }

        public void guardar()
        {
            cliente.Identificacion = txtIdentificacion.Text;
            cliente.Nombre = txtNombres.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.Telefono = txtTelefono.Text;
            cliente.Correo = txtCorreo.Text;

            try
            {
                if (txtIdentificacion.Text == "" || txtNombres.Text == "" || txtDireccion.Text == "" || txtTelefono.Text == "" || txtCorreo.Text == "")
                    MessageBox.Show(this.MdiParent, "Debe digitar todos los datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (cliente.insertar(cliente.Identificacion, cliente.Nombre, cliente.Direccion, cliente.Telefono, cliente.Correo))
                {
                    MessageBox.Show(MdiParent, "Cliente registrado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargaComboBox();
                }
            }
            catch
            {

                MessageBox.Show(MdiParent, "Cliente no registrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void consultar()
        {
            try
            {
                string seleccion = cboxConsultar.SelectedValue.ToString();
                cargaBuscar(seleccion);
            }
            catch
            {
                MessageBox.Show(this.MdiParent, "Error al momento de buscar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void modificar()
        {
            try
            {
                string seleccion = cboxModificar.SelectedValue.ToString();
                informe = cliente.consultar(seleccion);
                txt6Identificacion.Text = informe.Tables["Clientes"].Rows[0]["cliDocumento"].ToString();
                txt7Nombres.Text = informe.Tables["Clientes"].Rows[0]["cliNombre"].ToString();
                txt8Direccion.Text = informe.Tables["Clientes"].Rows[0]["cliDireccion"].ToString();
                txt9Telefono.Text = informe.Tables["Clientes"].Rows[0]["cliTelefono"].ToString();
                txt10Correo.Text = informe.Tables["Clientes"].Rows[0]["cliCorreo"].ToString();

            }
            catch
            {

                MessageBox.Show(MdiParent, "Error al momento de buscar el cliente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void guardaCambios()
        {
            try
            {
                cliente.Identificacion = txt6Identificacion.Text;
                cliente.Nombre = txt7Nombres.Text;
                cliente.Direccion = txt8Direccion.Text;
                cliente.Telefono = txt9Telefono.Text;
                cliente.Correo = txt10Correo.Text;

                if (cliente.Identificacion == "" || cliente.Nombre == "" || cliente.Direccion == "" || cliente.Telefono == "" || cliente.Correo == "")
                {
                    MessageBox.Show(this.MdiParent, "Debe llenar todos los espacios", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (cliente.modificar(cliente.Identificacion, cliente.Nombre, cliente.Direccion, cliente.Telefono, cliente.Correo))
                {
                    MessageBox.Show(this.MdiParent, "Datos del Cliente Modificados Exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargaDatos();
                    cargaComboBox();
                }

            }
            catch
            {

                MessageBox.Show(this.MdiParent, "Datos no modificados", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        public void eliminar()
        {
            try
            {
                string seleccion = cboxEliminar.SelectedValue.ToString();
                cliente.eliminar(seleccion);
                cargaComboBox();

                MessageBox.Show(this.MdiParent, "Cliente eliminado exitosamente", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show(this.MdiParent, "Cliente no eliminado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGuardar1_Click(object sender, EventArgs e)
        {
            guardar();
        }

        private void btnLimpiar1_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btn3Consultar_Click(object sender, EventArgs e)
        {
            consultar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            guardaCambios();
        }

        private void btn3Consulta_Click(object sender, EventArgs e)
        {
            modificar();
        }

        private void btnElimina_Click(object sender, EventArgs e)
        {
            eliminar();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Clientes_Load_1(object sender, EventArgs e)
        {

        }

        private void txtIdentificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt6Identificacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt7Nombres_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt8Direccion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt9Telefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt10Correo_TextChanged(object sender, EventArgs e)
        {

        }

        private void cboxConsultar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxModificar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cboxEliminar_SelectedIndexChanged(object sender, EventArgs e)
        {

        }




    }
}
