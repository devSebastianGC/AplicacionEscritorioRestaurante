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
    public partial class frmLogin : Form
    {
        private bool Campo_activado = true;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void activar_campos() 
        {
            if (Campo_activado == true)
            {
                panel1.Visible = true;
            }
            else if (Campo_activado == false)
            {
                panel1.Visible = false;
            }
        }

        private void rdbAdmin_Click(object sender, EventArgs e)
        {
            Campo_activado = true;
            activar_campos();
        }

        private void rdbEmpleado_Click(object sender, EventArgs e)
        {
            Campo_activado = true;
            activar_campos();
        }

        private void rdbCliente_Click(object sender, EventArgs e)
        {
            Campo_activado = true;
            activar_campos();
        }

        private void rdbInvitado_Click(object sender, EventArgs e)
        {
            Campo_activado = false;
            activar_campos();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
