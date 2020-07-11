using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEscritorio
{
    class InfoCajaReciboCajaOtrosIngresos
    {
        public string ReciboCajaOtrosIngresos(
            /* ------------------------------- */
            Int32 F_NUMERO_REG,
            Int32 F_TIPO_REG,
            Int32 F_SUBTIPO_REG,
            Int32 F_VERSION_REG,
            Int32 F_CIA,
            string F350_ID_CO,
            string F350_ID_TIPO_DOCTO,
            Int32  F350_CONSEC_DOCTO,
            string F358_ID_MEDIOS_PAGO,
            decimal F358_VALOR,
            string  F358_ID_BANCO,
            decimal F358_NRO_CHEQUE,
            string F358_NRO_CUENTA,
            string F358_COD_SEGURIDAD,
            string F358_NRO_AUTORIZACION,
            string F358_FECHA_VCTO,
            string F358_REFERENCIA_OTROS,
            string F358_FECHA_CONSIGNACION,
            string F358_ID_CAUSALES_DEVOLUCION,
            string F358_ID_TERCERO,
            string F358_NOTAS,
            string F358_ID_CCOSTO,
            string f358_nro_alt_docto_banco,
            string f358_docto_banco_cg,
            string f358_id_cta_bancaria_cg
            /* ------------------- */
            )
        {
            string cadena = "";

            cadena += F_NUMERO_REG.ToString("0000000");
            cadena += F_TIPO_REG.ToString("0357");
            cadena += F_SUBTIPO_REG.ToString("01");
            cadena += F_VERSION_REG.ToString("03");
            cadena += F_CIA.ToString("000");
            cadena += F350_ID_CO.PadRight(3, ' ');
            cadena += F350_ID_TIPO_DOCTO.PadRight(3, ' ');
            cadena += F350_CONSEC_DOCTO.ToString("00000000");
            cadena += F358_ID_MEDIOS_PAGO.PadRight(3, ' ');
            cadena += F358_VALOR.ToString("000000000000000000000.0000");
            cadena += F358_ID_BANCO.PadRight(10, ' ');
            cadena += F358_NRO_CHEQUE.ToString("00000000");
            cadena += F358_NRO_CUENTA.PadRight(25, ' ');
            cadena += F358_COD_SEGURIDAD.PadRight(3, ' ');
            cadena += F358_NRO_AUTORIZACION.PadRight(10, ' ');
            cadena += F358_FECHA_VCTO.PadRight(8, ' ');
            cadena += F358_REFERENCIA_OTROS.PadRight(30, ' ');
            cadena += F358_FECHA_CONSIGNACION.PadRight(8, ' ');
            cadena += F358_ID_CAUSALES_DEVOLUCION.PadRight(3, ' ');
            cadena += F358_ID_TERCERO.PadRight(15, ' ');
            cadena += F358_NOTAS.PadRight(255, ' ');
            cadena += F358_ID_CCOSTO.PadRight(15, ' ');
            cadena += f358_nro_alt_docto_banco.PadRight(30, ' ');
            cadena += f358_docto_banco_cg.PadRight(2, ' ');
            cadena += f358_id_cta_bancaria_cg.PadRight(3, ' ');

            return cadena;
        }
    }
}
