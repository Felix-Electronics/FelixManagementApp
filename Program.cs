using FelixManagementApp.Data;
using FelixManagementApp.Forms;
using FelixManagementApp.Repositories;
using FelixManagementApp.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace FelixManagementApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        public static IConfiguration configuration;

        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");

            configuration = builder.Build();

            var services = new ServiceCollection();
            ConfigureServices(services);

            using (var serviceProvider = services.BuildServiceProvider())
            {
                var mainForm = serviceProvider.GetRequiredService<FrmLogin>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            // Registro del DbContext
            services.AddDbContext<FelixElectronicsContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("FelixElectronicsDB")));

            // Registro del Unit of Work
            services.AddScoped<IUnitOfWork, UnitOfWork>();

            // Registro de los servicios
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<ITecnicoService, TecnicoService>();
            services.AddScoped<IOrdenService, OrdenService>();
            services.AddScoped<IEquipoService, EquipoService>();

            // Registro de los formularios
            services.AddTransient<FrmCliente>();
            services.AddTransient<FrmAgregarCliente>();
            services.AddTransient<FrmCrearOrden>();
            services.AddTransient<FrmActualizarOrden>();
            services.AddTransient<FrmEquipos>();
            services.AddTransient<FrmOrdenes>();
            services.AddTransient<FrmLogin>();
        }
    }
}
