using GPS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GPS.Services.ClientServices
{
    public interface IClientRepository
    {
        void Add(Client entity);
        void Delete(Client entity);
        void Update(Client entity);
        Task<Client[]> GetClients();
        Task<Client> GetClientById(int id);
        Task<Client> GetClientByTraceId(int id);


    }
}
