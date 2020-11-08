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
    public partial class frmMenus : Form
    {
        CN_Menu objetoCN = new CN_Menu();

        public frmMenus()
        {
            InitializeComponent();
        }

        private void frmMenus_Load(object sender, EventArgs e)
        {
            MostrarMenus();
            txtID.Enabled = false;
            lblID.Enabled = false;
        }

        //Limpiar Formulario
        private void limpiarForm()
        {
            txtNombreMenu.Clear();
            rtbDescripcion.Text = "";
            txtPrecio.Clear();
            txtID.Clear();
        }

        //Realiza una excepcion en caso de que existan campos vacios
        private void CamposVacios()
        {
            if (txtNombreMenu.Text.Equals("") || rtbDescripcion.Text.Equals("") || txtPrecio.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios" + "\nComplete o seleccione los datos");
            }
        }

        //Realiza una excepcion en caso de que existan campos vacios
        private void CamposVacios2()
        {
            if (txtNombreMenu.Text.Equals("") || rtbDescripcion.Text.Equals("") || txtPrecio.Text.Equals("") || txtID.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios" + "\nComplete o seleccione los datos");
            }
        }

        //Mostrar datos de la tabla en el datagridview
        private void MostrarMenus()
        {
            CN_Menu objeto = new CN_Menu();
            dataGridView1.DataSource = objeto.MostrarMen();
        }

        //Accion de boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CamposVacios();
                objetoCN.InsertarMen(txtNombreMenu.Text, rtbDescripcion.Text, txtPrecio.Text);
                MessageBox.Show("Se inserto correctamente");
                MostrarMenus();
                limpiarForm();
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
                objetoCN.EditarMen(txtNombreMenu.Text, rtbDescripcion.Text, txtPrecio.Text, txtID.Text);
                MessageBox.Show("Se edito correctamente");
                MostrarMenus();
                limpiarForm();
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
                txtID.Text = dataGridView1.CurrentRow.Cells["id_menu"].Value.ToString();
                objetoCN.EliminarMen(txtID.Text);
                MessageBox.Show("Eliminado correctamente");
                MostrarMenus();
                limpiarForm();
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
                txtID.Text = dataGridView1.CurrentRow.Cells["id_menu"].Value.ToString();
                txtNombreMenu.Text = dataGridView1.CurrentRow.Cells["nombre_menu"].Value.ToString();
                rtbDescripcion.Text = dataGridView1.CurrentRow.Cells["descripcion_menu"].Value.ToString();
                txtPrecio.Text = dataGridView1.CurrentRow.Cells["precio_menu"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila por favor");
            }
        }

        //Accion del boton salir
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
