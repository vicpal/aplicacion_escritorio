namespace AplicacionEscritorio.CrudUsuario
{
    partial class frmUsuarioBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarioBuscar));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.txtBuscarNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dgvConsulta = new System.Windows.Forms.DataGridView();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombretipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.btnAceptar);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.btnConsultar);
            this.splitContainer1.Panel1.Controls.Add(this.txtBuscarNombre);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvConsulta);
            this.splitContainer1.Size = new System.Drawing.Size(635, 256);
            this.splitContainer1.SplitterDistance = 100;
            this.splitContainer1.TabIndex = 0;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(548, 65);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 3;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(368, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Escriba el Texto:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(460, 65);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(75, 23);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // txtBuscarNombre
            // 
            this.txtBuscarNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBuscarNombre.Location = new System.Drawing.Point(460, 30);
            this.txtBuscarNombre.MaxLength = 50;
            this.txtBuscarNombre.Name = "txtBuscarNombre";
            this.txtBuscarNombre.Size = new System.Drawing.Size(163, 20);
            this.txtBuscarNombre.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dgvConsulta
            // 
            this.dgvConsulta.AllowUserToAddRows = false;
            this.dgvConsulta.AllowUserToDeleteRows = false;
            this.dgvConsulta.AllowUserToOrderColumns = true;
            this.dgvConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConsulta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuarioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.nombreusuarioDataGridViewTextBoxColumn,
            this.claveusuarioDataGridViewTextBoxColumn,
            this.idtipoDataGridViewTextBoxColumn,
            this.nombretipoDataGridViewTextBoxColumn});
            this.dgvConsulta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvConsulta.Location = new System.Drawing.Point(0, 0);
            this.dgvConsulta.MultiSelect = false;
            this.dgvConsulta.Name = "dgvConsulta";
            this.dgvConsulta.ReadOnly = true;
            this.dgvConsulta.RowHeadersVisible = false;
            this.dgvConsulta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsulta.Size = new System.Drawing.Size(635, 152);
            this.dgvConsulta.TabIndex = 4;
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idusuarioDataGridViewTextBoxColumn.MaxInputLength = 3;
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idusuarioDataGridViewTextBoxColumn.Width = 40;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre Completo";
            this.nombreDataGridViewTextBoxColumn.MaxInputLength = 50;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreDataGridViewTextBoxColumn.Width = 160;
            // 
            // nombreusuarioDataGridViewTextBoxColumn
            // 
            this.nombreusuarioDataGridViewTextBoxColumn.DataPropertyName = "nombre_usuario";
            this.nombreusuarioDataGridViewTextBoxColumn.HeaderText = "Nombre de Usuario";
            this.nombreusuarioDataGridViewTextBoxColumn.MaxInputLength = 20;
            this.nombreusuarioDataGridViewTextBoxColumn.Name = "nombreusuarioDataGridViewTextBoxColumn";
            this.nombreusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreusuarioDataGridViewTextBoxColumn.Width = 140;
            // 
            // claveusuarioDataGridViewTextBoxColumn
            // 
            this.claveusuarioDataGridViewTextBoxColumn.DataPropertyName = "clave_usuario";
            this.claveusuarioDataGridViewTextBoxColumn.HeaderText = "Clave de Usuario";
            this.claveusuarioDataGridViewTextBoxColumn.MaxInputLength = 20;
            this.claveusuarioDataGridViewTextBoxColumn.Name = "claveusuarioDataGridViewTextBoxColumn";
            this.claveusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.claveusuarioDataGridViewTextBoxColumn.Width = 140;
            // 
            // idtipoDataGridViewTextBoxColumn
            // 
            this.idtipoDataGridViewTextBoxColumn.DataPropertyName = "id_tipo";
            this.idtipoDataGridViewTextBoxColumn.HeaderText = "ID Tipo";
            this.idtipoDataGridViewTextBoxColumn.MaxInputLength = 3;
            this.idtipoDataGridViewTextBoxColumn.Name = "idtipoDataGridViewTextBoxColumn";
            this.idtipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtipoDataGridViewTextBoxColumn.Visible = false;
            this.idtipoDataGridViewTextBoxColumn.Width = 70;
            // 
            // nombretipoDataGridViewTextBoxColumn
            // 
            this.nombretipoDataGridViewTextBoxColumn.DataPropertyName = "nombre_tipo";
            this.nombretipoDataGridViewTextBoxColumn.HeaderText = "Tipo de Usuario";
            this.nombretipoDataGridViewTextBoxColumn.MaxInputLength = 20;
            this.nombretipoDataGridViewTextBoxColumn.Name = "nombretipoDataGridViewTextBoxColumn";
            this.nombretipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombretipoDataGridViewTextBoxColumn.Width = 140;
            // 
            // frmUsuarioBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 256);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarioBuscar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscar Usuario";
            this.Load += new System.EventHandler(this.frmUsuarioBuscar_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.TextBox txtBuscarNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.DataGridView dgvConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombretipoDataGridViewTextBoxColumn;
    }
}