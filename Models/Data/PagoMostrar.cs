using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebColegioPagos.Models.Data
{
    public class PagoMostrar
    {
        public int Pag_id { get; set; }

        public int Pag_cuota { get; set;}

        public int Estudiante {  get; set; }

        public int Pension { get; set; }

        public string Est_nombre;

        public float Pen_valor;
    }
}
