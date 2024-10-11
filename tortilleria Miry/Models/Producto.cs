using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Producto
    {
        public int IdProducto { get; set; }
        public string NombreProducto { get; set; }
        public string LoteProducto { get; set; }
        public int ClaseProductoId { get; set; }
        public ClaseProducto ClaseProducto { get; set; } 
        public int ProveedorId { get; set; }
        public Proveedor Proveedor { get; set; } 
        public decimal Precio { get; set; }
    }

}
