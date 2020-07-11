namespace AplicacionEscritorio
{
    partial class frmUsuarios
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnVer = new System.Windows.Forms.Button();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.claveusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pruebavisualDataSet = new AplicacionEscritorio.pruebavisualDataSet();
            this.usuarioTableAdapter = new AplicacionEscritorio.pruebavisualDataSetTableAdapters.usuarioTableAdapter();
            this.tipousuarioTableAdapter = new AplicacionEscritorio.pruebavisualDataSetTableAdapters.tipousuarioTableAdapter();
            this.tableAdapterManager = new AplicacionEscritorio.pruebavisualDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebavisualDataSet)).BeginInit();
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
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtBusqueda);
            this.splitContainer1.Panel1.Controls.Add(this.pictureBox1);
            this.splitContainer1.Panel1.Controls.Add(this.btnNuevo);
            this.splitContainer1.Panel1.Controls.Add(this.btnBuscar);
            this.splitContainer1.Panel1.Controls.Add(this.btnVer);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvUsuarios);
            this.splitContainer1.Size = new System.Drawing.Size(661, 430);
            this.splitContainer1.SplitterDistance = 130;
            this.splitContainer1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Busqueda de Registros:";
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.Location = new System.Drawing.Point(395, 99);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(130, 20);
            this.txtBusqueda.TabIndex = 4;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(540, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 107);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(12, 96);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(75, 23);
            this.btnNuevo.TabIndex = 1;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(174, 96);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnVer
            // 
            this.btnVer.Location = new System.Drawing.Point(93, 96);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(75, 23);
            this.btnVer.TabIndex = 2;
            this.btnVer.Text = "Ver";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click_1);
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.AllowUserToAddRows = false;
            this.dgvUsuarios.AllowUserToDeleteRows = false;
            this.dgvUsuarios.AllowUserToOrderColumns = true;
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuarioDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.nombreusuarioDataGridViewTextBoxColumn,
            this.claveusuarioDataGridViewTextBoxColumn,
            this.idtipoDataGridViewTextBoxColumn});
            this.dgvUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUsuarios.Location = new System.Drawing.Point(0, 0);
            this.dgvUsuarios.MultiSelect = false;
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.ReadOnly = true;
            this.dgvUsuarios.RowHeadersVisible = false;
            this.dgvUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuarios.Size = new System.Drawing.Size(661, 296);
            this.dgvUsuarios.TabIndex = 5;
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
            this.nombreDataGridViewTextBoxColumn.Width = 180;
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
            this.idtipoDataGridViewTextBoxColumn.DataPropertyName = "nombre_tipo";
            this.idtipoDataGridViewTextBoxColumn.HeaderText = "Tipo de Usuario";
            this.idtipoDataGridViewTextBoxColumn.MaxInputLength = 20;
            this.idtipoDataGridViewTextBoxColumn.Name = "idtipoDataGridViewTextBoxColumn";
            this.idtipoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtipoDataGridViewTextBoxColumn.Width = 140;
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataMember = "usuario";
            this.usuarioBindingSource.DataSource = this.pruebavisualDataSet;
            // 
            // pruebavisualDataSet
            // 
            this.pruebavisualDataSet.DataSetName = "pruebavisualDataSet";
            this.pruebavisualDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuarioTableAdapter
            // 
            this.usuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tipousuarioTableAdapter
            // 
            this.tipousuarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tipousuarioTableAdapter = this.tipousuarioTableAdapter;
            this.tableAdapterManager.UpdateOrder = AplicacionEscritorio.pruebavisualDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usuarioTableAdapter = null;
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.ClientSize = new System.Drawing.Size(661, 430);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUsuarios";
            this.Text = "Listado de Usuarios";
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pruebavisualDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnVer;
        private pruebavisualDataSet pruebavisualDataSet;
        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private pruebavisualDataSetTableAdapters.usuarioTableAdapter usuarioTableAdapter;
        private pruebavisualDataSetTableAdapters.tipousuarioTableAdapter tipousuarioTableAdapter;
        private pruebavisualDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn claveusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Label label1;
    }
}