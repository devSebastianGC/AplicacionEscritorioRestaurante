namespace Restaurante_C_SHARP.Vista
{
    partial class frmPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administracionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriaProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menúProductosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestionPersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.domiciliariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiónComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administracionToolStripMenuItem,
            this.gestionPersonasToolStripMenuItem,
            this.comprasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(793, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administracionToolStripMenuItem
            // 
            this.administracionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoriaProductosToolStripMenuItem,
            this.menúProductosToolStripMenuItem});
            this.administracionToolStripMenuItem.Name = "administracionToolStripMenuItem";
            this.administracionToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.administracionToolStripMenuItem.Text = "Gestion de Restaurante";
            // 
            // categoriaProductosToolStripMenuItem
            // 
            this.categoriaProductosToolStripMenuItem.Name = "categoriaProductosToolStripMenuItem";
            this.categoriaProductosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.categoriaProductosToolStripMenuItem.Text = "Categoria Productos";
            this.categoriaProductosToolStripMenuItem.Click += new System.EventHandler(this.categoriaProductosToolStripMenuItem_Click);
            // 
            // menúProductosToolStripMenuItem
            // 
            this.menúProductosToolStripMenuItem.Name = "menúProductosToolStripMenuItem";
            this.menúProductosToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.menúProductosToolStripMenuItem.Text = "Menú Productos";
            this.menúProductosToolStripMenuItem.Click += new System.EventHandler(this.menúProductosToolStripMenuItem_Click);
            // 
            // gestionPersonasToolStripMenuItem
            // 
            this.gestionPersonasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.domiciliariosToolStripMenuItem,
            this.clientesToolStripMenuItem});
            this.gestionPersonasToolStripMenuItem.Name = "gestionPersonasToolStripMenuItem";
            this.gestionPersonasToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.gestionPersonasToolStripMenuItem.Text = "Gestion Personas";
            // 
            // domiciliariosToolStripMenuItem
            // 
            this.domiciliariosToolStripMenuItem.Name = "domiciliariosToolStripMenuItem";
            this.domiciliariosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.domiciliariosToolStripMenuItem.Text = "Domiciliarios";
            this.domiciliariosToolStripMenuItem.Click += new System.EventHandler(this.domiciliariosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // comprasToolStripMenuItem
            // 
            this.comprasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiónComprasToolStripMenuItem});
            this.comprasToolStripMenuItem.Name = "comprasToolStripMenuItem";
            this.comprasToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.comprasToolStripMenuItem.Text = "Compras";
            // 
            // gestiónComprasToolStripMenuItem
            // 
            this.gestiónComprasToolStripMenuItem.Name = "gestiónComprasToolStripMenuItem";
            this.gestiónComprasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestiónComprasToolStripMenuItem.Text = "Gestión Compras";
            this.gestiónComprasToolStripMenuItem.Click += new System.EventHandler(this.gestiónComprasToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BackgroundImage = global::Restaurante_C_SHARP.Properties.Resources.Fondo;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(793, 397);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administracionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriaProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menúProductosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestionPersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem domiciliariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiónComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}