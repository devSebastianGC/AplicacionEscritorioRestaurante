using Restaurante_C_SHARP.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Restaurante_C_SHARP.Vista
{
    public partial class frmCompra : Form
    {
        CN_Compra objetoCN = new CN_Compra();

        private string entrega = null;
        private string id_cliente = null;
        private string id_domiciliario = null;
        private string id_menu = null;

        public frmCompra()
        {
            InitializeComponent();
        }

        private void frmCompra_Load(object sender, EventArgs e)
        {
            MostrarClientes();
            MostrarEmpleados();
            MostrarMenu();
            MostrarCompra();
            txtID.Enabled = false;
            lblID.Enabled = false;
            txtCliente.Enabled = false;
            txtDomiciliario.Enabled = false;
            txtMenu.Enabled = false;
        }

        //Mostrar datos de la tabla en el datagridview
        private void MostrarClientes()
        {
            CN_Compra objeto = new CN_Compra();
            dgvCliente.DataSource = objeto.MostrarCli();
        }

        private void MostrarEmpleados()
        {
            CN_Compra objeto = new CN_Compra();
            dgvDomiciliario.DataSource = objeto.MostrarDom();
        }

        private void MostrarMenu()
        {
            CN_Compra objeto = new CN_Compra();
            dgvMenu.DataSource = objeto.MostrarMenu();
        }

        private void MostrarCompra()
        {
            CN_Compra objeto = new CN_Compra();
            dgvCompra.DataSource = objeto.MostrarCompras();
        }

        //Limpiar Formulario
        private void limpiarForm()
        {
            txtCliente.Clear();
            txtDomiciliario.Clear();
            txtMenu.Clear();
            txtCantidad.Clear();
            gbEntregaRecibida.Text = "";
        }

        //Realiza una excepcion en caso de que existan campos vacios
        private void CamposVacios()
        {
            if (txtCliente.Text.Equals("") || txtDomiciliario.Text.Equals("") || txtMenu.Text.Equals("") || txtCantidad.Text.Equals("") || entrega == null)
            {
                MessageBox.Show("No se pueden dejar campos vacios" + "\nComplete o seleccione los datos");
            }
        }

        //Realiza una excepcion en caso de que existan campos vacios
        private void CamposVacios2()
        {
            if (txtCliente.Text.Equals("") || txtDomiciliario.Text.Equals("") || txtMenu.Text.Equals("") || txtCantidad.Text.Equals("") || entrega == null || txtID.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios" + "\nComplete o seleccione los datos");
            }
        }

        //Realiza la seleccion del genero de la fila que se seleccionó
        private void CampoSeleccionEntrega()
        {
            if (entrega.Equals("Si"))
            {
                rdbSi.Checked = true;
            }
            if (entrega.Equals("No"))
            {
                rdbNo.Checked = true;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CamposVacios();
                objetoCN.InsertarEmp(txtCliente.Text, txtDomiciliario.Text, txtMenu.Text, txtCantidad.Text, dtpFechaEntrega.CustomFormat, entrega);
                MessageBox.Show("Se inserto correctamente");
                MostrarCompra();
                limpiarForm();
                entrega = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se inserto correctamente por: " + ex);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                CamposVacios2();
                objetoCN.EditarEmp(txtCliente.Text, txtDomiciliario.Text, txtMenu.Text, txtCantidad.Text, dtpFechaEntrega.CustomFormat, entrega, txtID.Text);
                MessageBox.Show("Se edito correctamente");
                MostrarCompra();
                limpiarForm();
                entrega = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se edito correctamente por: " + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvCompra.SelectedRows.Count > 0)
            {
                CamposVacios();
                txtID.Text = dgvCompra.CurrentRow.Cells["id_compra"].Value.ToString();
                objetoCN.EliminarEmp(txtID.Text);
                MessageBox.Show("Eliminado correctamente");
                MostrarCompra();
                limpiarForm();
                entrega = null;
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnSeleccionarFormularios_Click(object sender, EventArgs e)
        {
            if (dgvCliente.SelectedRows.Count > 0 && dgvDomiciliario.SelectedRows.Count > 0 && dgvMenu.SelectedRows.Count > 0)
            {
                txtCliente.Text = dgvCliente.CurrentRow.Cells["nombre_cliente"].Value.ToString();
                id_cliente = dgvCliente.CurrentRow.Cells["id_cliente"].Value.ToString();
                txtDomiciliario.Text = dgvDomiciliario.CurrentRow.Cells["nombre_domiciliario"].Value.ToString();
                id_domiciliario = dgvDomiciliario.CurrentRow.Cells["id_domiciliario"].Value.ToString();
                txtMenu.Text = dgvMenu.CurrentRow.Cells["nombre_menu"].Value.ToString();
                id_menu = dgvMenu.CurrentRow.Cells["id_menu"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgvCompra.SelectedRows.Count > 0)
            {
                txtCliente.Text = dgvCompra.CurrentRow.Cells["nombre_cliente"].Value.ToString();
                txtDomiciliario.Text = dgvCompra.CurrentRow.Cells["nombre_domiciliario"].Value.ToString();
                txtMenu.Text = dgvCompra.CurrentRow.Cells["nombre_menu"].Value.ToString();
                txtCantidad.Text = dgvCompra.CurrentRow.Cells["cantidad"].Value.ToString();
                //dtpFechaEntrega = dgvCompra.CurrentRow.Cells["fecha_compra"].Value.ToString();
                entrega = dgvCompra.CurrentRow.Cells["entrega_recibida"].Value.ToString();
                CampoSeleccionEntrega();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void rdbSi_Click(object sender, EventArgs e)
        {
            entrega = rdbSi.Text;
        }

        private void rdbNo_Click(object sender, EventArgs e)
        {
            entrega = rdbNo.Text;
        }


        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
