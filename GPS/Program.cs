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
using GPS.Services.PaiementService;
using GPS.Forms;
using System.Data;
using GPS.Services.TraceServices;

namespace GPS
{
    static class Program
    {
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

            if (CheckConnection())
            {
                using (ServiceProvider serviceProvider = services.BuildServiceProvider())
                {
                    var form = serviceProvider.GetRequiredService<MainForm>();
                    Application.Run(form);
                }
            }
            else
            {
                Application.Exit();
            }



        }

        private static void ConfigureServices(ServiceCollection services)
        {
            services.AddScoped<GPSContext>();

            services.AddScoped<IClientRepository, ClientRepository>();
            //services.AddScoped<ITraceRepository, TraceRepository>();
            services.AddScoped<ITraceRepository, TraceRepository>();
            services.AddScoped<IPaiementRepository, PaiementRepository>();

            services.AddScoped<Form1>();
            services.AddScoped<MainForm>();
            services.AddTransient<AddForm>();
            services.AddTransient<PaymentForm>();
            services.AddTransient<ClientForm>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
        }

        private static bool CheckConnection()
        {
            using (var db = new GPSContext())
            {
                try
                {
                    db.Database.Connection.Open();
                }
                catch (Exception)
                {
                    var state = db.Database.Connection.State;
                    if (state == ConnectionState.Closed)
                    {
                        MessageBox.Show("Vérifier la connection avec la base de donnée", "DB Connection", MessageBoxButtons.OK);
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
