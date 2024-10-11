using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Pago
    {
        public int IdPago { get; set; }
        public int VentaId { get; set; }
        public Venta Venta { get; set; } 
        public decimal MontoPagado { get; set; }
        public string MetodoPago { get; set; } 
        public DateTime FechaPago { get; set; }
    }

}
