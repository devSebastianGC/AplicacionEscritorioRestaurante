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
    public partial class frmGestionCategoriasProductos : Form
    {
        CN_Categoria objetoCN = new CN_Categoria();

        public frmGestionCategoriasProductos()
        {
            InitializeComponent();
        }

        private void frmGestionCategoriasProductos_Load(object sender, EventArgs e)
        {
            MostrarCategoria();
            txtID.Enabled = false;
            lblID.Enabled = false;
        }

        //Limpiar Formulario
        private void limpiarForm()
        {
            txtNombreCategoria.Clear();
            txtID.Clear();
        }

        //Realiza una excepcion en caso de que existan campos vacios
        private void CamposVacios()
        {
            if (txtNombreCategoria.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios" + "\nComplete o seleccione los datos");
            }
        }

        //Realiza una excepcion en caso de que existan campos vacios
        private void CamposVacios2()
        {
            if (txtNombreCategoria.Text.Equals("") || txtID.Text.Equals(""))
            {
                MessageBox.Show("No se pueden dejar campos vacios" + "\nComplete o seleccione los datos");
            }
        }

        //Mostrar datos de la tabla en el datagridview
        private void MostrarCategoria()
        {
            CN_Categoria objeto = new CN_Categoria();
            dataGridView1.DataSource = objeto.MostrarCat();
        }

        //Accion de boton guardar
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                CamposVacios();
                objetoCN.InsertarCat(txtNombreCategoria.Text);
                MessageBox.Show("Se inserto correctamente");
                MostrarCategoria();
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
                objetoCN.EditarCat(txtNombreCategoria.Text, txtID.Text);
                MessageBox.Show("Se edito correctamente");
                MostrarCategoria();
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
                CamposVacios2();
                txtID.Text = dataGridView1.CurrentRow.Cells["id_categoria"].Value.ToString();
                objetoCN.EliminarCat(txtID.Text);
                MessageBox.Show("Eliminado correctamente");
                MostrarCategoria();
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
                txtID.Text = dataGridView1.CurrentRow.Cells["id_categoria"].Value.ToString();
                txtNombreCategoria.Text = dataGridView1.CurrentRow.Cells["nombre_categoria"].Value.ToString();
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
