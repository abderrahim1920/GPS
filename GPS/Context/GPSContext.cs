using GPS.Models;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.Context
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class GPSContext : DbContext
    {
        public DbSet<Client> Clients { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Trace> Traces { get; set; }

        public GPSContext() : base("name=connectionString")
        {

        }
    }
}
