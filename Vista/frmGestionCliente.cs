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
    public partial class frmGestionCliente : Form
    {
        CN_Cliente objetoCN = new CN_Cliente();
        private string genero = null;

        public frmGestionCliente()
        {
            InitializeComponent();
        }

        private void frmGestionCliente_Load(object sender, EventArgs e)
        {
            MostrarClientes();
            txtID.Enabled = false;
            lblID.Enabled = false;
        }

        //Limpiar Formulario
        private void limpiarForm()
        {
            txtNombre.Clear();
            gbGeneroCliente.Text = "";
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtID.Clear();
        }

        //Realiza una excepcion en caso de que existan campos vacios
        private void CamposVacios()
        {
            if (txtNombre.Text.Equals("") || genero == null || txtTelefono.Text.Equals("") || txtDireccion.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios" + "\nComplete o seleccione los datos");
            }
        }

        //Realiza una excepcion en caso de que existan campos vacios
        private void CamposVacios2()
        {
            if (txtNombre.Text.Equals("") || genero == null || txtTelefono.Text.Equals("") || txtDireccion.Text.Equals("") || txtID.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios" + "\nComplete o seleccione los datos");
            }
        }

        //Realiza la seleccion del genero de la fila que se seleccionó
        private void CampoSeleccionGenero()
        {
            if (genero.Equals("Masculino"))
            {
                rdbMasculino.Checked = true;
            }
            if (genero.Equals("Femenino"))
            {
                rdbFemenino.Checked = true;
            }
            if (genero.Equals("Otro"))
            {
                rdbOtro.Checked = true;
            }
        }


        //Mostrar datos de la tabla en el datagridview
        private void MostrarClientes()
        {
            CN_Cliente objeto = new CN_Cliente();
            dataGridView1.DataSource = objeto.MostrarCli();
        }

        //Accion de boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CamposVacios();
                objetoCN.InsertarCli(txtNombre.Text, genero, txtTelefono.Text, txtDireccion.Text);
                MessageBox.Show("Se inserto correctamente");
                MostrarClientes();
                limpiarForm();
                genero = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se inserto correctamente por: " + ex);
            }
        }

        //Accion de boton editar
        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                CamposVacios2();
                objetoCN.EditarCli(txtNombre.Text, genero, txtTelefono.Text, txtDireccion.Text, txtID.Text);
                MessageBox.Show("Se edito correctamente");
                MostrarClientes();
                limpiarForm();
                genero = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se edito correctamente por: " + ex);
            }
        }

        //Accion de boton eliminar
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CamposVacios();
                txtID.Text = dataGridView1.CurrentRow.Cells["id_cliente"].Value.ToString();
                objetoCN.EliminarCli(txtID.Text);
                MessageBox.Show("Eliminado correctamente");
                MostrarClientes();
                limpiarForm();
                genero = null;
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        //Accion de boton seleccionar
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtID.Text = dataGridView1.CurrentRow.Cells["id_cliente"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre_cliente"].Value.ToString();
                genero = dataGridView1.CurrentRow.Cells["genero_cliente"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["telefono_cliente"].Value.ToString();
                txtDireccion.Text = dataGridView1.CurrentRow.Cells["direccion_cliente"].Value.ToString();

                CampoSeleccionGenero();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        //Accion al hacer click en el radio buttom masculino
        private void rdbMasculino_Click(object sender, EventArgs e)
        {
            genero = rdbMasculino.Text;
        }

        //Accion al hacer click en el radio buttom femenino
        private void rdbFemenino_Click(object sender, EventArgs e)
        {
            genero = rdbFemenino.Text;
        }

        //Accion al hacer click en el radio buttom otro
        private void rdbOtro_Click(object sender, EventArgs e)
        {
            genero = rdbOtro.Text;
        }

        //Accion del boton salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
