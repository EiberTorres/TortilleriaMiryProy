using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Pedido
    {
        public int IdPedido { get; set; }
        public int IdCliente { get; set; }
        public Cliente Cliente { get; set; } 
        public DateTime FechaPedido { get; set; }
        public decimal Total { get; set; }
        public decimal Pagado { get; set; }
        public string Estado { get; set; } 
    }

}
