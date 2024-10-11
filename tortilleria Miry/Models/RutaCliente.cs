using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class RutaCliente
    {
        public int IdRuta { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; } 
        public string PuntoInicio { get; set; }
        public string PuntoDestino { get; set; }
        public decimal Distancia { get; set; }
        public TimeSpan TiempoEstimado { get; set; }
        public DateTime FechaRegistro { get; set; }
    }

}
