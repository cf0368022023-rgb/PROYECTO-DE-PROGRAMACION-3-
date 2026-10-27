using LacteosLaFe.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using LacteosLaFe.Business;

namespace LacteosLaFe.View
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var configuration = new ConfigurationBuilder()
                .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                .AddJsonFile(
                    "appsettings.json",
                    optional: false,
                    reloadOnChange: true)
                .Build();

            var services = new ServiceCollection();

            services.AddDbContext<LacteosLaFeDbContext>(options =>
                options.UseSqlServer(
                    configuration.GetConnectionString("DefaultConnection"),
                    b => b.MigrationsAssembly("LacteosLaFe.Infrastructure")
                ));

            // Repositorios
            services.AddScoped<ProductRepository>();
            services.AddScoped<ClientRepository>();
            services.AddScoped<SupplierRepository>();
            services.AddScoped<InventoryLocationRepository>();

            // Formularios
            services.AddTransient<LoginForm>();
            services.AddTransient<BaseCrudForm>();
            services.AddTransient<ProductsForm>();
            services.AddTransient<ClientsForm>();
            services.AddTransient<SuppliersForm>();
            services.AddTransient<InventoryLocationsForm>();

            var serviceProvider = services.BuildServiceProvider();

            // Temporalmente abrimos Ubicaciones de Inventario para probarlo
            var mainForm =
                serviceProvider.GetRequiredService<InventoryLocationsForm>();

            Application.Run(mainForm);
        }
    }
}