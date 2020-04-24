using GPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.Services.TraceServices
{
    public interface ITracerepository
    {
        void Add(Trace entity);
        void Delete(Trace entity);
        void Update(Trace entity);
        Task<Trace[]> GetTraces(bool includeClients = false);
        Task<Trace> GetTraceById(int id, bool includeClient = false);
    }
}
