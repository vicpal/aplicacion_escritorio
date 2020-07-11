using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/* -- Esta linea llama a la Carpeta Clases y desde alli puedo llamar sus archivos -- */
using System.Data.SqlClient;
using AplicacionEscritorio.Clases;
using AplicacionEscritorio.CrudUsuario;

namespace AplicacionEscritorio
{
    public partial class frmUsuarios : Form
    {
        public frmUsuarios()
        {
            InitializeComponent();
            btnBuscar.Enabled = false;
        }
        public Usuario_A UsuarioIdActual { get; set; }
        public Usuario_A usuarioSeleccionado { get; set; }
        /* ----------------- ESTE METODO PERMITE ACTUALIZAR EL DATAGRIDVIEW DESPUES DE GUARDAR UN REGISTRO ------------------- */
        public void F2_ActualizarEventHandler1(object sender, frmUsuarioNuevo.ActualizarEventArgs args)
        {
            Usuario NuevoRegistro = new Usuario();
            NuevoRegistro.cargarDatoUsuario(dgvUsuarios);
        }
        /* -------------- FIN - ESTE METODO PERMITE ACTUALIZAR EL DATAGRIDVIEW DESPUES DE GUARDAR UN REGISTRO ---------------- */
        /* ------------------------------------------------------------------------------------------------------------------- */
        /* ----------------- ESTE METODO PERMITE ACTUALIZAR EL DATAGRIDVIEW DESPUES DE EDITAR UN REGISTRO -------------------- */
        public void F3_ActualizarEventHandler12(object sender, frmUsuarioEditar.ActualizarEventArgs args)
        {
            Usuario EditarRegistro = new Usuario();
            EditarRegistro.cargarDatoUsuario(dgvUsuarios);
        }
        /* -------------- FIN - ESTE METODO PERMITE ACTUALIZAR EL DATAGRIDVIEW DESPUES DE EDITAR UN REGISTRO ----------------- */
        /* ------------------------------------------------------------------------------------------------------------------- */
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            /* ----------- DATAGRIDVIEW ------------ */
            Usuario datausu = new Usuario();
            datausu.cargarDatoUsuario(dgvUsuarios);
            /* --------- FIN DATAGRIDVIEW ---------- */
        }
        /* ------------------------------------------------------------------------------------------------------------------- */
        /* ------------------------------------------ SECCION DE BOTONES ----------------------------------------------------- */
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmUsuarioNuevo UsuarioNuevo = new frmUsuarioNuevo(this);
            UsuarioNuevo.ActualizarEventHandler += F2_ActualizarEventHandler1;
            UsuarioNuevo.MdiParent = this.MdiParent; /* -- ESTA LINEA ABRE AL NIETO DENTRO DE SU ABUELO -- */
            UsuarioNuevo.Show();
        }
        /* ----------------------------------------------------- */
        private void btnVer_Click_1(object sender, EventArgs e)
        {
            {
                if (dgvUsuarios.SelectedRows.Count == 1)
                {
                    Int32 id_usuario = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value);
                    usuarioSeleccionado = Usuario.obtenerIdUsuario(id_usuario);

                    frmUsuarioEditar editarUsuario = new frmUsuarioEditar(this);
                    editarUsuario.ActualizarEventHandler1 += F3_ActualizarEventHandler12;
                    editarUsuario.UsuarioSeleccionado2 = usuarioSeleccionado;
                    editarUsuario.MdiParent = this.MdiParent;
                    editarUsuario.Show();
                }
                else
                {
                    MessageBox.Show("Aun No Ha Seleccionado Ningun Usuario", "Seleccionar Usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }
        /* ----------------------------------------------------- */
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            frmUsuarioBuscar buscarUsuario = new frmUsuarioBuscar();
            buscarUsuario.MdiParent = this.MdiParent;
            buscarUsuario.Show();
            if(buscarUsuario.usuarioSeleccionado != null)
            {
                UsuarioIdActual = buscarUsuario.usuarioSeleccionado;
            }
        }
        /* ------------------------------------------ FIN - SECCIÓN BOTONES -------------------------------------------------- */
        /* ------------------------------------------------------------------------------------------------------------------- */
        /* ----------------------------------- TEXTBOX PARA BUSQUEDA DE REGISTROS -------------------------------------------- */
        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
            SqlConnection Conn = Conexion.ObtenerConexion();
            //Conn.Open();
            SqlCommand cmd = Conn.CreateCommand();
            cmd.CommandText = "SELECT DISTINCT a.id_usuario, a.nombre, a.nombre_usuario, a.clave_usuario, a.id_tipo, b.nombre_tipo FROM usuario a INNER JOIN tipousuario b ON a.nombre like ('%" + txtBusqueda.Text + "%') WHERE a.id_tipo = b.id_tipo";
            cmd.ExecuteNonQuery();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);

            da.Fill(dt);
            dgvUsuarios.DataSource = dt;
            Conn.Close();
        }
        /* --------------------------------- FIN - TEXTBOX PARA BUSQUEDA DE REGISTROS ---------------------------------------- */
    }
}
