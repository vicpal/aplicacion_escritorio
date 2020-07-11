namespace AplicacionEscritorio
{
    partial class frmProgramaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProgramaPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.crearClientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarFormulariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarTodoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.cerrarTodoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.crearUsuariosToolStripMenuItem,
            this.crearClientesToolStripMenuItem,
            this.cerrarFormulariosToolStripMenuItem,
            this.cerrarProgramaToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // crearUsuariosToolStripMenuItem
            // 
            this.crearUsuariosToolStripMenuItem.Name = "crearUsuariosToolStripMenuItem";
            this.crearUsuariosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.crearUsuariosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.crearUsuariosToolStripMenuItem.Text = "Listar Usuarios";
            this.crearUsuariosToolStripMenuItem.Click += new System.EventHandler(this.crearUsuariosToolStripMenuItem_Click);
            // 
            // crearClientesToolStripMenuItem
            // 
            this.crearClientesToolStripMenuItem.Name = "crearClientesToolStripMenuItem";
            this.crearClientesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
            this.crearClientesToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.crearClientesToolStripMenuItem.Text = "Listar Clientes";
            this.crearClientesToolStripMenuItem.Click += new System.EventHandler(this.crearClientesToolStripMenuItem_Click);
            // 
            // cerrarFormulariosToolStripMenuItem
            // 
            this.cerrarFormulariosToolStripMenuItem.Name = "cerrarFormulariosToolStripMenuItem";
            this.cerrarFormulariosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.cerrarFormulariosToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.cerrarFormulariosToolStripMenuItem.Text = "Cerrar Formularios";
            this.cerrarFormulariosToolStripMenuItem.Click += new System.EventHandler(this.cerrarFormulariosToolStripMenuItem_Click);
            // 
            // cerrarProgramaToolStripMenuItem
            // 
            this.cerrarProgramaToolStripMenuItem.Name = "cerrarProgramaToolStripMenuItem";
            this.cerrarProgramaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cerrarProgramaToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.cerrarProgramaToolStripMenuItem.Text = "Cerrar Programa";
            this.cerrarProgramaToolStripMenuItem.Click += new System.EventHandler(this.cerrarProgramaToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeUsuariosToolStripMenuItem});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // listadoDeUsuariosToolStripMenuItem
            // 
            this.listadoDeUsuariosToolStripMenuItem.Name = "listadoDeUsuariosToolStripMenuItem";
            this.listadoDeUsuariosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.listadoDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(217, 22);
            this.listadoDeUsuariosToolStripMenuItem.Text = "Listado de Usuarios";
            this.listadoDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeUsuariosToolStripMenuItem_Click);
            // 
            // cerrarTodoToolStripMenuItem
            // 
            this.cerrarTodoToolStripMenuItem.Name = "cerrarTodoToolStripMenuItem";
            this.cerrarTodoToolStripMenuItem.Size = new System.Drawing.Size(80, 20);
            this.cerrarTodoToolStripMenuItem.Text = "Cerrar Todo";
            this.cerrarTodoToolStripMenuItem.Click += new System.EventHandler(this.cerrarTodoToolStripMenuItem_Click);
            // 
            // frmProgramaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 386);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmProgramaPrincipal";
            this.Text = "Programa Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProgramaPrincipal_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem crearClientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarFormulariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarProgramaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarTodoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeUsuariosToolStripMenuItem;
    }
}