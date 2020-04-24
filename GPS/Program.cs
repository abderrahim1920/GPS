using AutoMapper;
using GPS.DTO;
using GPS.Models;
using GPS.Services.ClientServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using GPS.Context;
using GPS.Services.TraceServices;
using GPS.Services.PaiementService;
using GPS.Forms;

namespace GPS
{
    static class Program
    {
        private static Container container;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var services = new ServiceCollection();

            ConfigureServices(services);
            //using (ServiceProvider serviceProvider = services.BuildServiceProvider())
            //{
            //    var form1 = serviceProvider.GetRequiredService<Form1>();
            //    Application.Run(form1);
            //}
            Application.Run(new MainForm());
        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<GPSContext>();

            services.AddScoped<IClientRepository, ClientRepository>();
            services.AddScoped<ITracerepository, Tracerepository>();
            services.AddScoped<IPaiementRepository, PaiementRepository>();

            services.AddScoped<Form1>();
            
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }
    }
}
