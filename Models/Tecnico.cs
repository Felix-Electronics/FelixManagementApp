using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelixManagementApp.Models
{
    public class Tecnico
    {
        public int id_tecnico { get; set; }
        public string nombre { get; set; } = string.Empty;
        public string apellido_paterno { get; set; } = string.Empty;
        public string apellido_materno { get; set; } = string.Empty;
        public string correo { get; set; } = string.Empty;
        public string contrasenia { get; set; } = string.Empty;
    }
}
