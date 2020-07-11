using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* ------------------------------- */
using AplicacionEscritorio.CrudUsuario;

namespace AplicacionEscritorio
{
    public partial class frmProgramaPrincipal : Form
    {
        public frmProgramaPrincipal()
        {
            InitializeComponent();
        }
        /* --------------- CON ESTE CÓDIGO LLAMAMOS EL FORMULARIO HIJO ---------------- */
        private void crearUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios NuevoUsuario = new frmUsuarios();
            NuevoUsuario.MdiParent = this;
            NuevoUsuario.Show();
        }

        private void crearClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClientes NuevoCliente = new frmClientes();
            NuevoCliente.MdiParent = this;
            NuevoCliente.Show();
        }
        /* ------------------ FIN - CÓDIGO LLAMAMOS EL FORMULARIO HIJO ------------------ */
        /* ------------------------------------------------------------------------------ */
        /* --------- CON ESTE CÓDIGO EJECUTAMOS EL SALIR/CERRAR DE LA APLICACIÓN -------- */
        private void cerrarFormulariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (!frm.Focused)
                {
                    frm.Visible = false;
                    frm.Dispose();
                }
            }
        }

        private void cerrarProgramaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cerrarTodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listadoDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteUsuarios ListadoUsuarios = new frmReporteUsuarios();
            ListadoUsuarios.Refresh(); /* La Idea es que esta linea Actualice de forma automatica los datos del reporte */
            ListadoUsuarios.Show();
        }

        private void frmProgramaPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        /* ------------------- FIN EL SALIR/CERRAR DE LA APLICACIÓN -------------------- */
    }
}
