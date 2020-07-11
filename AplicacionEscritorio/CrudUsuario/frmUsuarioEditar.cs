using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using AplicacionEscritorio.Clases;
using AplicacionEscritorio.CrudUsuario;

namespace AplicacionEscritorio.CrudUsuario
{
    public partial class frmUsuarioEditar : Form
    {
        SqlConnection Conn = Conexion.ObtenerConexion();
        public frmUsuarioEditar(frmUsuarios frmUsuarios)
        {
            InitializeComponent();
        }
        public Usuario_A UsuarioSeleccionado2 { get; set; } /* -------- ESTA VARIABLE CONTIENE TODA LA INFORMACIÓN DE UN REGISTRO, VIENE DEL FRMUSUARIO 1 --------- */
        /* ------------------------------------------------------------------------------------------------------------------ */
        /* ------------- METODOS PARA LOGRAR ACTUALIZAR EL FORMULARIO PRINCIPAL DESPUES DE EDITAR UN REGISTRO --------------- */
        public delegate void ActualizarDelegate(object sender, ActualizarEventArgs e);
        public event ActualizarDelegate ActualizarEventHandler1; /* --- Este es para Editar --- */
        public class ActualizarEventArgs : EventArgs
        {
            public string Data1 { get; set; }
        }
        /* ----------- ESTE METODO PERMITE CAPTURAR EL REGISTRO DE BOTON EDITAR Y ENVIAR AL FORMULARIO PRINCIPAL ------------ */
        public void ActualizarGriidViewRegistro()
        {
            ActualizarEventArgs args = new ActualizarEventArgs();
            ActualizarEventHandler1.Invoke(this, args);
        }
        /* ------- FIN - ESTE METODO PERMITE CAPTURAR EL REGISTRO DE BOTON EDITAR Y ENVIAR AL FORMULARIO PRINCIPAL ---------- */
        /* ------------------------------------------------------------------------------------------------------------------ */
        private void frmUsuarioEditar_Load(object sender, EventArgs e)
        {
            verRegistroActual();
        }
        /* ------------------------------------------------------------ */
        private void verRegistroActual()
        {
            txtComboEditar.Text = UsuarioSeleccionado2.nombre_tipo;
            txtNombre.Text = UsuarioSeleccionado2.nombre;
            txtUsuario.Text = UsuarioSeleccionado2.nombre_usuario;
            txtClave.Text = UsuarioSeleccionado2.clave_usuario;
        }
        /* ------------------------------------------------------------ */
        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Usuario_A pUsuario_A = new Usuario_A();
            //pUsuario_A.nombre_tipo = txtComboEditar.Text;
            pUsuario_A.nombre = txtNombre.Text;
            pUsuario_A.nombre_usuario = txtUsuario.Text;
            pUsuario_A.clave_usuario = txtClave.Text;

            pUsuario_A.id_usuario = UsuarioSeleccionado2.id_usuario;

            MessageBox.Show("Esta Seguro de Modificar el Registro", "Seguridad", MessageBoxButtons.OK, MessageBoxIcon.Question);
            int resultado = Usuario.editarDatoUsuario(pUsuario_A);
            if (resultado > 0)
            {
                MessageBox.Show("Usuario Modificado con Exito", "Modulo de Edición", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ActualizarGriidViewRegistro();
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al Modificar Usuario", "Ocurrio un Error!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /* ------------------------------------------------------------ */
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta Seguro que desea Eliminar el Registro?", "Eliminación de Registros", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int resultado = Usuario.eliminarDatoUsuario(UsuarioSeleccionado2.id_usuario);
                if (resultado > 0)
                {
                    MessageBox.Show("Usuario Eliminado Correctamente", "Eliminación de Registros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarGriidViewRegistro();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo Eliminar el Usuario", "Error al Eliminar!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Se cancelo la Eliminación del Usuario", "Cancelado Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
        /* ------------------------------------------------------------ */
    }
}
