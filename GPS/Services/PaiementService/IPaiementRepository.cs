using GPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.Services.PaiementService
{
    public interface IPaiementRepository
    {
        void Add(Payment entity);
        void Delete(Payment entity);
        void Update(Payment entity);
        Task<Payment[]> GetPayments(bool includetraces = false, bool includeClients = false);
        Task<Payment> GetPaymentById(int id, bool includetraces = false, bool includeClient = false);
    }
}
