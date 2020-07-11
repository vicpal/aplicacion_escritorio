using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AplicacionEscritorio.Clases;
using AplicacionEscritorio.CrudUsuario;

namespace AplicacionEscritorio.CrudUsuario
{
    public partial class frmUsuarioBuscar : Form
    {
        public frmUsuarioBuscar()
        {
            InitializeComponent();
        }

        public Usuario_A usuarioSeleccionado { get; set; }

        private void frmUsuarioBuscar_Load(object sender, EventArgs e)
        {
            //
        }
        /* ------------------------------------------ SECCION DE BOTONES ---------------------------------------------------- */
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            dgvConsulta.DataSource = Usuario.buscarDatoUsuario(txtBuscarNombre.Text);
            txtBuscarNombre.Text = "";
            txtBuscarNombre.Focus();
        }
        /* ----------------------------------------------------- */
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (dgvConsulta.SelectedRows.Count == 1)
            {
                Int32 id_usuario = Convert.ToInt32(dgvConsulta.CurrentRow.Cells[0].Value);
                usuarioSeleccionado = Usuario.obtenerIdUsuario(id_usuario);
                MessageBox.Show("Este es el Valor que está en la Variable usuarioSeleccionar -> " + usuarioSeleccionado);
                MessageBox.Show("Este es el Valor que está en la Variable Id_usuario -> " + id_usuario);
                this.Close();
            }
            else
            {
                MessageBox.Show("Aun No Ha Seleccionado Ningun Usuario", "Seleccionar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        /* --------------------------------------- FIN - SECCION DE BOTONES ------------------------------------------------- */
    }
}
