using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class DetallePedido
    {
        public int IdDetalle { get; set; }
        public int IdPedido { get; set; }
        public Pedido Pedido { get; set; } 
        public int IdProducto { get; set; }
        public Producto Producto { get; set; } 
        public decimal Cantidad { get; set; }
        public decimal Precio { get; set; }
    }

}
