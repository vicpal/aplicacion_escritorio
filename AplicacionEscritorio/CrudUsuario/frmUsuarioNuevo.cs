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
    public partial class frmUsuarioNuevo : Form
    {
        SqlConnection Conn = Conexion.ObtenerConexion();
        public frmUsuarioNuevo(frmUsuarios frmUsuarios)
        {
            InitializeComponent();
        }
        /* ------------------------------------------------------------------------------------------------------------------ */
        /* ------------- METODOS PARA LOGRAR ACTUALIZAR EL FORMULARIO PRINCIPAL DESPUES DE GUARDAR UN REGISTRO -------------- */
        public delegate void ActualizarDelegate(object sender, ActualizarEventArgs e);
        public event ActualizarDelegate ActualizarEventHandler;
        public class ActualizarEventArgs : EventArgs
        {
            public string Data { get; set; }
        }
        /* ----------- ESTE METODO PERMITE CAPTURAR EL REGISTRO DE BOTON GUARDAR Y ENVIAR AL FORMULARIO PRINCIPAL ----------- */
        public void ActualizarDataGridV()
        {
            ActualizarEventArgs args = new ActualizarEventArgs();
            ActualizarEventHandler.Invoke(this, args);
        }
        /* ------- FIN - ESTE METODO PERMITE CAPTURAR EL REGISTRO DE BOTON GUARDAR Y ENVIAR AL FORMULARIO PRINCIPAL --------- */
        /* ------------------------------------------------------------------------------------------------------------------ */
        public void limpiarNuevo()
        {
            ComboBox.DataSource = Usuario.ObtenerTipoUsuario();
            txtNombre.Text = "";
            txtUsuario.Text = "";
            txtClave.Text = "";
        }
        private void frmUsuarioNuevo_Load(object sender, EventArgs e)
        {
            ComboBox.DropDownStyle = ComboBoxStyle.DropDownList; /* -- Esta linea es para evitar que borren el dato del Combobox -- */
            ComboBox.DataSource = Usuario.ObtenerTipoUsuario();
            ComboBox.DisplayMember = "nombre_tipo";
            ComboBox.ValueMember = "id_tipo";
        }
        /* ------------------------------------------ SECCION DE BOTONES ---------------------------------------------------- */
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text.Length == 0)
            {
                MessageBox.Show("El campo NOMBRE no puede quedar vacio");
            }
            else if (txtUsuario.Text.Length == 0 || txtClave.Text.Length == 0)
            {
                MessageBox.Show("El campo USUARIO y/o CLAVE no puede quedar vacio");
            }
            else
            {
                Usuario_A pUsuario = new Usuario_A();
                pUsuario.nombre = txtNombre.Text;
                pUsuario.nombre_usuario = txtUsuario.Text;
                pUsuario.clave_usuario = txtClave.Text;
                pUsuario.id_tipo = Convert.ToInt32(ComboBox.SelectedValue);
                if (Usuario.ValidarExistencia(Convert.ToString(txtUsuario.Text)))
                {
                    MessageBox.Show("Nombre de Usuario Ya Existe", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (Usuario.guardarDatoUsuario(pUsuario) > 0)
                {
                    MessageBox.Show("Usuario Creado Correctamente", "Registro de Usuarios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ActualizarDataGridV();
                    limpiarNuevo();
                }
                else
                {
                    MessageBox.Show("Error al intentar Almacenar Usuario", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                }
            }
        }
        /* ------------------------------------------------------------------------------------------------------------------ */
    }
}
