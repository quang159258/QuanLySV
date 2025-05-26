using System;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using DAL;

namespace QuanLySV
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var host = CreateHostBuilder().Build();

            ApplicationConfiguration.Initialize();

            var form = host.Services.GetRequiredService<HomePage>();
            Application.Run(form);
        }

        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureServices((context, services) =>
                {
                    // Đăng ký DbContext với connection string
                    services.AddDbContext<AppDbContext>(options =>
                        options.UseSqlServer("Data Source=NGUYENTRANQUANG;Initial Catalog=QuanLySV;Integrated Security=True;Trust Server Certificate=True"));

                    // Đăng ký Form1 để có thể inject DbContext vào constructor
                    services.AddTransient<HomePage>();
                });
    }
}
