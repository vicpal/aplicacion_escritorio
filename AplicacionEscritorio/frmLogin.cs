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

namespace AplicacionEscritorio
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        public void logins(string nombre_usuario, string clave_usuario)
        {
            SqlConnection Conn = Conexion.ObtenerConexion();
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT nombre, id_tipo FROM usuario WHERE nombre_usuario = @nombre_usuario AND clave_usuario = @clave_usuario", Conn);
                cmd.Parameters.AddWithValue("nombre_usuario", nombre_usuario);
                cmd.Parameters.AddWithValue("clave_usuario", clave_usuario);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (txtUsuario.Text.Length == 0)
                {
                    MessageBox.Show("El Campo del Usuario No debe estar vacio!!", "Error de Inicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else if (txtClave.Text.Length == 0)
                {
                    MessageBox.Show("El Campo de la Clave No debe estar vacio!!", "Error de Inicio", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (dt.Rows.Count == 1)
                    {
                        this.Hide();
                        if (Convert.ToInt32(dt.Rows[0][1]).ToString() == "1") /* -- La expresion "Convert.ToInt32" permite convertir de STRING a INT -- */
                        {
                            MessageBox.Show("Welcome Administrator", "Iniciando Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new frmProgramaPrincipal().Show();
                        }
                        else if (Convert.ToInt32(dt.Rows[0][1]).ToString() == "2") /* -- La expresion "Convert.ToInt32" permite convertir de STRING a INT -- */
                        {
                            MessageBox.Show("Welcome Usuario del Sistema", "Iniciando Sesion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            new frmProgramaPrincipal().Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuario y/o Contraseña Incorrecta", "Inicio de Sesion Incorrecto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtUsuario.Text = "";
                        txtClave.Text = "";
                        txtUsuario.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                Conn.Close();
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            logins(this.txtUsuario.Text, this.txtClave.Text);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
