namespace AplicacionEscritorio.CrudUsuario
{
    partial class frmUsuarioNuevo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarioNuevo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtClave = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.ComboBox = new System.Windows.Forms.ComboBox();
            this.lblClave = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.txtClave);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.ComboBox);
            this.groupBox1.Controls.Add(this.lblClave);
            this.groupBox1.Controls.Add(this.lblUsuario);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.lblTipoUsuario);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(420, 187);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Crear Nuevo Usuario";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(175, 153);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 23);
            this.btnGuardar.TabIndex = 5;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(283, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 114);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(113, 124);
            this.txtClave.MaxLength = 20;
            this.txtClave.Name = "txtClave";
            this.txtClave.PasswordChar = '*';
            this.txtClave.Size = new System.Drawing.Size(136, 20);
            this.txtClave.TabIndex = 4;
            // 
            // txtUsuario
            // 
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtUsuario.Location = new System.Drawing.Point(113, 93);
            this.txtUsuario.MaxLength = 20;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(137, 20);
            this.txtUsuario.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(113, 62);
            this.txtNombre.MaxLength = 20;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(136, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // ComboBox
            // 
            this.ComboBox.FormattingEnabled = true;
            this.ComboBox.Location = new System.Drawing.Point(113, 30);
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Size = new System.Drawing.Size(137, 21);
            this.ComboBox.TabIndex = 1;
            // 
            // lblClave
            // 
            this.lblClave.AutoSize = true;
            this.lblClave.Location = new System.Drawing.Point(42, 126);
            this.lblClave.Name = "lblClave";
            this.lblClave.Size = new System.Drawing.Size(64, 13);
            this.lblClave.TabIndex = 41;
            this.lblClave.Text = "Contraseña:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(60, 95);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 40;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 64);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 13);
            this.lblNombre.TabIndex = 39;
            this.lblNombre.Text = "Nombre Completo:";
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Location = new System.Drawing.Point(21, 33);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(85, 13);
            this.lblTipoUsuario.TabIndex = 38;
            this.lblTipoUsuario.Text = "Tipo de Usuario:";
            // 
            // frmUsuarioNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 211);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarioNuevo";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuevo";
            this.Load += new System.EventHandler(this.frmUsuarioNuevo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtClave;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox ComboBox;
        private System.Windows.Forms.Label lblClave;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.Button btnGuardar;
    }
}