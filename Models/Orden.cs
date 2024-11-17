using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FelixManagementApp.Models
{
    public class Orden
    {
        public int id_orden { get; set; }
        public DateTime fecha_creacion { get; set; }
        public int id_cliente { get; set; }
        public virtual Cliente? Cliente { get; set; }
    }
}
