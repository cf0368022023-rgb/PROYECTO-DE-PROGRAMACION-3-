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
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .Build();

            var services = new ServiceCollection();

            services.AddDbContext<LacteosLaFeDbContext>(options =>
     options.UseSqlServer(
         configuration.GetConnectionString("DefaultConnection"),
         b => b.MigrationsAssembly("LacteosLaFe.Infrastructure")
     ));

            services.AddScoped<ProductRepository>();

            services.AddTransient<LoginForm>();
            services.AddTransient<BaseCrudForm>();
            services.AddTransient<ProductsForm>();
            var serviceProvider = services.BuildServiceProvider();
            var mainForm = serviceProvider.GetRequiredService<LoginForm>();
            Application.Run(mainForm);
        } 

    }
}