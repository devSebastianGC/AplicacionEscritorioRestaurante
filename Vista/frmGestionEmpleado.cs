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
    public partial class frmGestionEmpleado : Form
    {
        CN_Empleado objetoCN = new CN_Empleado();
        private string genero = null;
        public frmGestionEmpleado()
        {
            InitializeComponent();
        }
        
        private void frmGestionEmpleado_Load(object sender, EventArgs e)
        {
            MostrarEmpleados();
            txtID.Enabled = false;
            lblID.Enabled = false;
        }


        //Limpiar Formulario
        private void limpiarForm()
        {
            txtNombre.Clear();
            gbGeneroCliente.Text = "";
            txtTelefono.Clear();
            txtID.Clear();
        }

        //Realiza una excepcion en caso de que existan campos vacios
        private void CamposVacios()
        {
            if (txtNombre.Text.Equals("") || genero == null || txtTelefono.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios" + "\nComplete o seleccione los datos");
            }
        }

        //Realiza una excepcion en caso de que existan campos vacios
        private void CamposVacios2()
        {
            if (txtNombre.Text.Equals("") || genero == null || txtTelefono.Text.Equals("") || txtID.Text.Equals(""))
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
        private void MostrarEmpleados()
        {
            CN_Empleado objeto = new CN_Empleado();
            dataGridView1.DataSource = objeto.MostrarEmp();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CamposVacios();
                objetoCN.InsertarEmp(txtNombre.Text, genero, txtTelefono.Text);
                MessageBox.Show("Se inserto correctamente");
                MostrarEmpleados();
                limpiarForm();
                genero = null;
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
                objetoCN.EditarEmp(txtNombre.Text, genero, txtTelefono.Text, txtID.Text);
                MessageBox.Show("Se edito correctamente");
                MostrarEmpleados();
                limpiarForm();
                genero = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se edito correctamente por: " + ex);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CamposVacios();
                txtID.Text = dataGridView1.CurrentRow.Cells["id_domiciliario"].Value.ToString();
                objetoCN.EliminarEmp(txtID.Text);
                MessageBox.Show("Eliminado correctamente");
                MostrarEmpleados();
                limpiarForm();
                genero = null;
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtID.Text = dataGridView1.CurrentRow.Cells["id_domiciliario"].Value.ToString();
                txtNombre.Text = dataGridView1.CurrentRow.Cells["nombre_domiciliario"].Value.ToString();
                genero = dataGridView1.CurrentRow.Cells["genero_domiciliario"].Value.ToString();
                txtTelefono.Text = dataGridView1.CurrentRow.Cells["telefono_domiciliario"].Value.ToString();

                CampoSeleccionGenero();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        private void rdbMasculino_Click(object sender, EventArgs e)
        {
            genero = rdbMasculino.Text;
        }

        private void rdbFemenino_Click(object sender, EventArgs e)
        {
            genero = rdbFemenino.Text;
        }

        private void rdbOtro_Click(object sender, EventArgs e)
        {
            genero = rdbOtro.Text;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
