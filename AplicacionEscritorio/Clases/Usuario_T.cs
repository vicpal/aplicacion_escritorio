using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEscritorio.Clases
{
    public class Usuario_T
    {
        public int id_tipo { get; set; }
        public string nombre_tipo { get; set; }
        
        public Usuario_T() { }

        public Usuario_T(int paid_tipo, string panombre_tipo)
        {
            this.id_tipo = paid_tipo;
            this.nombre_tipo = panombre_tipo;
        }
    }
}
