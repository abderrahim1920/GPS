using GPS.Context;
using GPS.Models;
using GPS.Services.ClientServices;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.Services.PaiementService
{
    public class PaiementRepository : IPaiementRepository
    {
        private readonly GPSContext _context;
        private readonly IClientRepository _clientRepository;

        public PaiementRepository(GPSContext gPSContext, IClientRepository clientRepository)
        {
            _context = gPSContext;
            _clientRepository = clientRepository;
        }
        public void Add(Payment entity)
        {
            _context.Payments.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            _context.Payments.Remove(_context.Payments.Find(id));
            _context.SaveChanges();
        }

        public async Task<Payment> GetPaymentById(int id, bool includetraces = false, bool includeClient = false)
        {
            IQueryable<Payment> query = _context.Payments.Where(t => t.PaiementId == id);
            if (includetraces)
            {
                query = query.Include(c => c.Trace);
                if (includeClient)
                {
                    var result = query.FirstOrDefaultAsync().Result;
                    var client = _clientRepository.GetClientByTraceId(result.TraceId).Result;
                    query.FirstOrDefaultAsync().Result.Trace.Client = client;
                }
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task<Payment[]> GetPayments(bool includetraces = false, bool includeClients = false)
        {
            IQueryable<Payment> query = _context.Payments;
            if (includetraces)
            {
                query = query.Include(c => c.Trace);
               
                if (includeClients)
                {
                    var res = query.ToArrayAsync().Result;
                    for (int i = 0; i < res.Length; i++)
                    {
                        var client = _clientRepository.GetClientByTraceId(res[i].TraceId).Result;
                        query.ToArrayAsync().Result[i].Trace.Client = client;
                    }
                }
            }


            return await query.ToArrayAsync();
        }

        public void Update(Payment entity)
        {
            _context.Payments.AddOrUpdate(entity);
        }
    }
}
