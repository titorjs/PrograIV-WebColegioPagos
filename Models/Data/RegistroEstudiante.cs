using System.ComponentModel.DataAnnotations;

namespace WebColegioPagos.Models.Data
{
    public class RegistroEstudiante
    {
        public string Est_cedula { get; set; }

        public string Est_nombre { get; set; }

        public string Est_direccion { get; set; }
        
        public Boolean paga {  get; set; }

        public string Est_contrasenia { get; set; }
    }
}
