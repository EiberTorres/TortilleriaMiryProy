using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using capaEntidad;
using Microsoft.EntityFrameworkCore;


namespace tortilleria_Miry.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Cliente> Clientes { get; set; } = null!;   // Opción: Usa null-forgiving operator para evitar la advertencia de inicialización
        public DbSet<Producto> Productos { get; set; } = null!;
        public DbSet<Pedido> Pedidos { get; set; } = null!;
        public DbSet<Pedido> Pago { get; set; } = null!;
        public DbSet<Pedido> Pedido { get; set; } = null!;
        public DbSet<Pedido> Producto { get; set; } = null!;
        public DbSet<Pedido> RutaCliente { get; set; } = null!;
        public DbSet<Pedido> Usuario { get; set; } = null!;
        public DbSet<Pedido> Venta { get; set; } = null!;
        public DbSet<Pedido> ClaseProducto { get; set; } = null!;



    }


}
