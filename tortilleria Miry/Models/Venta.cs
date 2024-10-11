using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Venta
    {
        public int IdVenta { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } 
        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; } 
        public DateTime FechaVenta { get; set; }
        public decimal TotalVenta { get; set; }
        public int TransaccionId { get; set; }
    }

}
