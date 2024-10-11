using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Inventario
    {
        public int IdInventario { get; set; }
        public int IdProducto { get; set; }
        public Producto Producto { get; set; } 
        public decimal CantidadDisponible { get; set; }
        public DateTime FechaActualizacion { get; set; }
    }

}
