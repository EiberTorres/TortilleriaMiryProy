using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace capaEntidad
{
    public class Cliente
    {
        public int IdCliente { get; set; }
        public string TipoCliente { get; set; } // 'REGULAR', 'NEGOCIO'
        public string NombreCliente { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }

    }
}
