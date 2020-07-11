namespace AplicacionEscritorio.CrudUsuario
{
    partial class frmUsuarioEditar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarioEditar));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.txtComboEditar = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(142, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(177, 34);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(85, 13);
            this.lblTipoUsuario.TabIndex = 31;
            this.lblTipoUsuario.Text = "Tipo de Usuario:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(168, 65);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 13);
            this.lblNombre.TabIndex = 32;
            this.lblNombre.Text = "Nombre Completo:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(216, 96);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 33;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(198, 127);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(64, 13);
            this.lblClave.TabIndex = 34;
            this.lblClave.Text = "Contraseña:";
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(269, 62);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.Tag = "";
            // 
            // txtUsuario
            // 
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Location = new System.Drawing.Point(269, 93);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(137, 20);
            this.txtUsuario.TabIndex = 2;
            this.txtUsuario.Tag = "";
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(269, 124);
            this.txtClave.MaxLength = 20;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(136, 20);
            this.txtClave.TabIndex = 3;
            this.txtClave.Tag = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnActualizar);
            this.groupBox1.Controls.Add(this.txtComboEditar);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblClave);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblTipoUsuario);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Editar Usuario";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(331, 153);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(250, 153);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(75, 23);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Tag = "";
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // txtComboEditar
            // 
            this.txtComboEditar.Location = new System.Drawing.Point(269, 31);
            this.txtComboEditar.MaxLength = 20;
            this.txtComboEditar.Name = "txtComboEditar";
            this.txtComboEditar.ReadOnly = true;
            this.txtComboEditar.Size = new System.Drawing.Size(136, 20);
            this.txtComboEditar.TabIndex = 100;
            this.txtComboEditar.Tag = "";
            // 
            // frmUsuarioEditar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 211);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarioEditar";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar";
            this.Load += new System.EventHandler(this.frmUsuarioEditar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtComboEditar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
    }
}