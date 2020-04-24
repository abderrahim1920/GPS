using GPS.Context;
using GPS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.Services.TraceServices
{
    public class Tracerepository : ITracerepository
    {
        private readonly GPSContext _context;

        public Tracerepository(GPSContext gPSContext)
        {
            _context = gPSContext;
        }
        public void Add(Trace entity)
        {
            _context.Traces.Add(entity);
            _context.SaveChanges();
        }

        public void Delete(Trace entity)
        {
            _context.Traces.Remove(entity);
        }

        public async Task<Trace> GetTraceById(int id, bool includeClient = false)
        {
            IQueryable<Trace> query = _context.Traces.Where(t => t.TraceId == id);
            if (includeClient)
            {
                query = query.Include(c => c.Client);
            }
            return await query.FirstOrDefaultAsync();
        }

        public async Task<Trace[]> GetTraces(bool includeClients = false)
        {
            IQueryable<Trace> query = _context.Traces;
            if (includeClients)
            {
                query = query.Include(c => c.Client);
            }
            return await query.ToArrayAsync();
        }

        public void Update(Trace entity)
        {
            _context.Traces.Remove(entity);
        }
    }
}
