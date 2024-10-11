using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;
using System;
using tortilleria_Miry.Datos;

namespace tortilleria_Miry
{
    static class Program
    {
        public static IConfiguration Configuration { get;  private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Cargar la configuración desde appsettings.json
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            Configuration = builder.Build();

            // Configurar el DbContext con la cadena de conexión
            var optionsBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionsBuilder.UseMySql(Configuration.GetConnectionString("MySqlConnection"),
                                    ServerVersion.AutoDetect(Configuration.GetConnectionString("MySqlConnection")));

            // Iniciar la aplicación
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(new ApplicationDbContext(optionsBuilder.Options)));
        }
    }
}