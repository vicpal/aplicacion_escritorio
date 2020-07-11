using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEscritorio.Clases
{
    public class Usuario_A
    {
        /* ------- Estas declaraciones se usan para llenar el ComboBox y el Metodo AGREGAR REGISTRO ------ */
        public Int32 id_usuario { get; set; }
        public String nombre { get; set; }
        public String nombre_usuario { get; set; }
        public String clave_usuario { get; set; }
        public int id_tipo { get; set; }
        public String nombre_tipo { get; set; }

        public Usuario_A() { }
        public Usuario_A(Int32 pid_usuario, string pnombre, string pnombre_usuario, string pclave_usuario, int pid_tipo, string pnombre_tipo)
        {
            this.id_usuario = pid_usuario;
            this.nombre = pnombre;
            this.nombre_usuario = pnombre_usuario;
            this.clave_usuario = pclave_usuario;
            this.id_tipo = pid_tipo;
            this.nombre_tipo = pnombre_tipo;
        }
        /* ---- FIN - Estas declaraciones se usan para llenar el ComboBox y el Metodo AGREGAR REGISTRO ----- */
    }
}
