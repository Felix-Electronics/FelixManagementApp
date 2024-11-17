using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelixManagementApp.Models
{
    public class Equipo
    {
        public int id_equipo { get; set; }
        public string marca { get; set; } = string.Empty;
        public string modelo { get; set; } = string.Empty;
        public string? contrasenia_equipo { get; set; }
        public string? accesorios { get; set; }
        public string problema { get; set; } = string.Empty;
        public string estatus { get; set; } = string.Empty;
        public DateTime? fecha_entrega { get; set; }
        public int id_orden { get; set; }
        public int id_tecnico { get; set; }
        public int id_cliente { get; set; }
        public virtual Cliente? Cliente { get; set; }
        public virtual Orden? Orden { get; set; }
        public virtual Tecnico? Tecnico { get; set; }
    }
}
