namespace Restaurante_C_SHARP.Vista
{
    partial class frmLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.gbRol = new System.Windows.Forms.GroupBox();
            this.rdbInvitado = new System.Windows.Forms.RadioButton();
            this.rdbCliente = new System.Windows.Forms.RadioButton();
            this.rdbEmpleado = new System.Windows.Forms.RadioButton();
            this.rdbAdmin = new System.Windows.Forms.RadioButton();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtID_rol = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbRol.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(181, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // gbRol
            // 
            this.gbRol.Controls.Add(this.rdbInvitado);
            this.gbRol.Controls.Add(this.rdbCliente);
            this.gbRol.Controls.Add(this.rdbEmpleado);
            this.gbRol.Controls.Add(this.rdbAdmin);
            this.gbRol.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.gbRol.Location = new System.Drawing.Point(28, 55);
            this.gbRol.Name = "gbRol";
            this.gbRol.Size = new System.Drawing.Size(398, 54);
            this.gbRol.TabIndex = 3;
            this.gbRol.TabStop = false;
            this.gbRol.Text = "Rol";
            // 
            // rdbInvitado
            // 
            this.rdbInvitado.AutoSize = true;
            this.rdbInvitado.Location = new System.Drawing.Point(298, 20);
            this.rdbInvitado.Name = "rdbInvitado";
            this.rdbInvitado.Size = new System.Drawing.Size(63, 17);
            this.rdbInvitado.TabIndex = 3;
            this.rdbInvitado.TabStop = true;
            this.rdbInvitado.Text = "Invitado";
            this.rdbInvitado.UseVisualStyleBackColor = true;
            this.rdbInvitado.Click += new System.EventHandler(this.rdbInvitado_Click);
            // 
            // rdbCliente
            // 
            this.rdbCliente.AutoSize = true;
            this.rdbCliente.Location = new System.Drawing.Point(222, 20);
            this.rdbCliente.Name = "rdbCliente";
            this.rdbCliente.Size = new System.Drawing.Size(57, 17);
            this.rdbCliente.TabIndex = 2;
            this.rdbCliente.TabStop = true;
            this.rdbCliente.Text = "Cliente";
            this.rdbCliente.UseVisualStyleBackColor = true;
            this.rdbCliente.Click += new System.EventHandler(this.rdbCliente_Click);
            // 
            // rdbEmpleado
            // 
            this.rdbEmpleado.AutoSize = true;
            this.rdbEmpleado.Location = new System.Drawing.Point(121, 20);
            this.rdbEmpleado.Name = "rdbEmpleado";
            this.rdbEmpleado.Size = new System.Drawing.Size(72, 17);
            this.rdbEmpleado.TabIndex = 1;
            this.rdbEmpleado.TabStop = true;
            this.rdbEmpleado.Text = "Empleado";
            this.rdbEmpleado.UseVisualStyleBackColor = true;
            this.rdbEmpleado.Click += new System.EventHandler(this.rdbEmpleado_Click);
            // 
            // rdbAdmin
            // 
            this.rdbAdmin.AutoSize = true;
            this.rdbAdmin.Location = new System.Drawing.Point(29, 20);
            this.rdbAdmin.Name = "rdbAdmin";
            this.rdbAdmin.Size = new System.Drawing.Size(54, 17);
            this.rdbAdmin.TabIndex = 0;
            this.rdbAdmin.TabStop = true;
            this.rdbAdmin.Text = "Admin";
            this.rdbAdmin.UseVisualStyleBackColor = true;
            this.rdbAdmin.Click += new System.EventHandler(this.rdbAdmin_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.PaleGreen;
            this.btnIngresar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnIngresar.Location = new System.Drawing.Point(90, 203);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(108, 29);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "&Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(250, 203);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(108, 29);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "&Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtContraseña);
            this.panel1.Controls.Add(this.txtID_rol);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(28, 127);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(398, 70);
            this.panel1.TabIndex = 6;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(195, 40);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '•';
            this.txtContraseña.Size = new System.Drawing.Size(166, 20);
            this.txtContraseña.TabIndex = 11;
            // 
            // txtID_rol
            // 
            this.txtID_rol.Location = new System.Drawing.Point(195, 7);
            this.txtID_rol.Name = "txtID_rol";
            this.txtID_rol.Size = new System.Drawing.Size(166, 20);
            this.txtID_rol.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(26, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "ID Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(26, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contraseña";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.gbRol);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.btnIngresar);
            this.panel2.Location = new System.Drawing.Point(29, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(461, 254);
            this.panel2.TabIndex = 7;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = global::Restaurante_C_SHARP.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(524, 317);
            this.Controls.Add(this.panel2);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.gbRol.ResumeLayout(false);
            this.gbRol.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbRol;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.RadioButton rdbCliente;
        private System.Windows.Forms.RadioButton rdbEmpleado;
        private System.Windows.Forms.RadioButton rdbAdmin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtID_rol;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbInvitado;
        private System.Windows.Forms.Panel panel2;
    }
}