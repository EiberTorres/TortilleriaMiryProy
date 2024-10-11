using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Egreso
    {
        public int IdEgreso { get; set; }
        public string Concepto { get; set; }
        public decimal Monto { get; set; }
        public DateTime FechaEgreso { get; set; }
        public string Categoria { get; set; } 
        public string Notas { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; } // Relación con Usuario
    }

}
