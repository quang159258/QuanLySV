using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using DAL;
using BLL.UnitOfWork;
using BLL.Services;
using QuanLySV.Views;

namespace QuanLySV
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();

            using (var scope = host.Services.CreateScope())
            {
                var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                context.Database.EnsureCreated();
            }

            ApplicationConfiguration.Initialize();

            var login = host.Services.GetRequiredService<LoginPage>();
            Application.Run(login);
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Đăng ký DbContext với connection string
                    services.AddDbContext<AppDbContext>(options =>
                        options.UseSqlServer("Data Source=NGUYENTRANQUANG;Initial Catalog=QuanLySV;Integrated Security=True;Trust Server Certificate=True"));
                    //Đăng ký unit of work và các services
                    services.AddScoped<IUnitOfWork, UnitOfWork>();
                    services.AddScoped<AuthService>();
                    // Đăng ký Form để có thể DI vào constructor
                    services.AddTransient<LoginPage>();
                    services.AddTransient<HomePage>();
                    services.AddScoped<IServiceProvider>(sp => sp);
                });
    }
}
