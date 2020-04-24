using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.DTO.GridData
{
    public class DataDTO
    {

        //ClientData
        public int ClientId { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string City { get; set; }

        //TraceData
        public int TraceId { get; set; }
        public string TraceName { get; set; }
        public DateTime RenewDate { get; set; }
        public string IMEI { get; set; }

        //PaiementData
        public DateTime PaiementDate { get; set; }
        public int PaiementId { get; set; }
        public bool Payee { get; set; }

    }
}
