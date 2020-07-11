using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
/* ---------------------------- */
using System.Windows.Forms;

namespace AplicacionEscritorio.Clases
{
    public class Usuario
    {
        /* ---------------------------------- METODO PARA LLENAR EL DATAGRIDVIEW ---------------------------------- */
        public void cargarDatoUsuario(DataGridView dgv)
        {
            SqlDataAdapter da;
            DataTable dt;
            try
            {
                SqlConnection Conn = Conexion.ObtenerConexion();
                da = new SqlDataAdapter("SELECT a.id_usuario, a.nombre, a.nombre_usuario, a.clave_usuario, b.nombre_tipo FROM usuario a INNER JOIN tipousuario b ON a.id_tipo = b.id_tipo", Conn);
                dt = new DataTable();
                da.Fill(dt);
                dgv.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo llenar el DataGridView " + ex.ToString());
            }
        }
        /* ------------------------------ FIN - METODO PARA LLENAR EL DATAGRIDVIEW -------------------------------- */
        /* -------------------------------------------------------------------------------------------------------- */
        /* ------------------------ METODO PARA VALIDAR EXISTENCIA DE NOMBRE DE USUARIO --------------------------- */
        public static bool ValidarExistencia(string nombre_usuario)
        {
            SqlConnection Conn = Conexion.ObtenerConexion();
            {
                string query = "SELECT COUNT(*) FROM usuario WHERE nombre_usuario = @nombre_usuario";
                SqlCommand cmd = new SqlCommand(query, Conn);
                cmd.Parameters.AddWithValue("nombre_usuario", nombre_usuario);

                int count = Convert.ToInt32(cmd.ExecuteScalar());
                if (count == 0)
                    return false;
                else
                    return true;
            }
        }
        /* ---------------------- FIN -METODO PARA VALIDAR EXISTENCIA DE NOMBRE DE USUARIO ------------------------ */
        /* -------------------------------------------------------------------------------------------------------- */
        /* ------------------------------------ METODO PARA GUARDAR REGISTROS ------------------------------------- */
        public static int guardarDatoUsuario(Usuario_A pUsuario)
        {
            int retorno;
            SqlConnection Conn = Conexion.ObtenerConexion();
            SqlCommand _comando = new SqlCommand(
                String.Format("INSERT INTO Usuario(nombre, nombre_usuario, clave_usuario, id_tipo) VALUES('{0}','{1}','{2}',{3})",
                pUsuario.nombre, pUsuario.nombre_usuario, pUsuario.clave_usuario, pUsuario.id_tipo), Conn);
            retorno = _comando.ExecuteNonQuery();
            Conn.Close();
            return retorno;
        }
        /* --------------------------------- FIN - METODO PARA GUARDAR REGISTROS ---------------------------------- */
        /* -------------------------------------------------------------------------------------------------------- */
        /* ------------------------------------- METODO PARA EDITAR REGISTROS ------------------------------------- */
        public static int editarDatoUsuario(Usuario_A pUsuario)
        {
            int retorno = 0;
            using (SqlConnection Conn = Conexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("UPDATE usuario SET nombre = '{0}', nombre_usuario = '{1}', clave_usuario = '{2}' WHERE id_usuario = {3}", pUsuario.nombre, pUsuario.nombre_usuario, pUsuario.clave_usuario, pUsuario.id_usuario), Conn);
                retorno = comando.ExecuteNonQuery();
                Conn.Close();
            }
            return retorno;
        }
        /* ---------------------------------- FIN - METODO PARA EDITAR REGISTROS ---------------------------------- */
        /* -------------------------------------------------------------------------------------------------------- */
        /* ----------------------------------- METODO PARA ELIMINAR REGISTROS ------------------------------------- */
        public static int eliminarDatoUsuario(Int32 pid_usuario)
        {
            int retorno = 0;
            using (SqlConnection Conn = Conexion.ObtenerConexion())
            {
                SqlCommand comando = new SqlCommand(string.Format("DELETE FROM usuario WHERE id_usuario = {0}", pid_usuario), Conn);
                retorno = comando.ExecuteNonQuery();
                Conn.Close();
            }
            return retorno;
        }
        /* ---------------------------------- FIN - METODO PARA ELIMINAR REGISTROS --------------------------------- */
        /* --------------------------------------------------------------------------------------------------------- */
        /* ---------------------- METODO PARA BUSCAR REGISTROS Y VER EN EL DATAGRIDVIEW ---------------------------- */
        public static List<Usuario_A> buscarDatoUsuario(String pnombre)
        {
            List<Usuario_A> ListaBuscar = new List<Usuario_A>();
            using (SqlConnection Conn = Conexion.ObtenerConexion())
            {
                SqlCommand cmd = new SqlCommand(string.Format("SELECT DISTINCT a.id_usuario, a.nombre, a.nombre_usuario, a.clave_usuario, a.id_tipo, b.nombre_tipo FROM usuario a INNER JOIN tipousuario b ON a.nombre like '%{0}%' WHERE a.id_tipo = b.id_tipo", pnombre), Conn);

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Usuario_A pUsuario_A = new Usuario_A();

                    pUsuario_A.id_usuario = reader.GetInt32(0);
                    pUsuario_A.nombre = reader.GetString(1);
                    pUsuario_A.nombre_usuario = reader.GetString(2);
                    pUsuario_A.clave_usuario = reader.GetString(3);
                    pUsuario_A.id_tipo = reader.GetInt32(4);
                    //pUsuario_A.id_tipo = reader.GetInt32(5);
                    pUsuario_A.nombre_tipo = reader.GetString(5);

                    ListaBuscar.Add(pUsuario_A);
                }
                Conn.Close();
                return ListaBuscar;
            }
        }
        /* ------------------- FIN - METODO PARA BUSCAR REGISTROS Y VER EN EL DATAGRIDVIEW ------------------------- */
        /* --------------------------------------------------------------------------------------------------------- */
        /* ------------------------------------ METODO PARA LLENAR EL COMBOBOX ------------------------------------- */
        public static List<Usuario_T> ObtenerTipoUsuario()
        {
            List<Usuario_T> _lista = new List<Usuario_T>();
            SqlConnection Conn = Conexion.ObtenerConexion();
            SqlCommand _comando = new SqlCommand("SELECT id_tipo, nombre_tipo FROM tipousuario", Conn);
            SqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Usuario_T pusuario = new Usuario_T();
                pusuario.id_tipo = _reader.GetInt32(0);
                pusuario.nombre_tipo = _reader.GetString(1);

                _lista.Add(pusuario);
            }
            return _lista;
        }
        /* --------------------------------- FIN - METODO PARA LLENAR EL COMBOBOX ---------------------------------- */
        /* --------------------------------------------------------------------------------------------------------- */
        /* ------------------------------------- METODO PARA OBTENER LA ID ----------------------------------------- */
        public static Usuario_A obtenerIdUsuario(Int32 pid_usuario) /* -- METODO SHOW -- */
        {
            using (SqlConnection Conn = Conexion.ObtenerConexion())
            {
                Usuario_A pUsuario_A = new Usuario_A();
                SqlCommand cmd = new SqlCommand(string.Format("SELECT a.id_usuario, a.nombre, a.nombre_usuario, a.clave_usuario, b.nombre_tipo FROM usuario a INNER JOIN tipousuario b ON a.id_tipo = b.id_tipo WHERE id_usuario = {0}", pid_usuario), Conn);
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    pUsuario_A.id_usuario = reader.GetInt32(0);
                    pUsuario_A.nombre = reader.GetString(1);
                    pUsuario_A.nombre_usuario = reader.GetString(2);
                    pUsuario_A.clave_usuario = reader.GetString(3);
                    pUsuario_A.nombre_tipo = reader.GetString(4);
                }
                Conn.Close();
                return pUsuario_A;
            }
        }
        /* ----------------------------------- FIN - METODO PARA OBTENER LA ID ------------------------------------- */
        /* --------------------------------------------------------------------------------------------------------- */
    }
}
