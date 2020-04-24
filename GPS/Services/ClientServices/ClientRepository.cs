using GPS.Context;
using GPS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.Services.ClientServices
{
    public class ClientRepository : IClientRepository
    {
        private readonly GPSContext _context;

        public ClientRepository(GPSContext gPSContext)
        {
            _context = gPSContext;
        }
        public void Add(Client entity)
        {
            _context.Clients.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Client entity)
        {
            _context.Clients.Remove(entity);
        }

        public async Task<Client> GetClientById(int id)
        {
            var query = _context.Clients.Where(c => c.ClientId == id);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<Client> GetClientByTraceId(int id)
        {
            var query = _context.Traces.Where(c => c.TraceId == id).Include(c => c.Client).Select(c => c.Client);
            return await query.FirstOrDefaultAsync();
        }

        public async Task<Client[]> GetClients()
        {
            return await _context.Clients.ToArrayAsync();
        }

        public void Update(Client entity)
        {
            _context.Clients.AddOrUpdate(entity);
        }
    }
}
