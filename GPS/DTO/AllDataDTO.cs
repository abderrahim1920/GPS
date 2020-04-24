using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.DTO
{
    public class AllDataDTO
    {

        public int ClientId { get; set; }

        public string Login { get; set; }

        public string PhoneNumber { get; set; }

        public string Name { get; set; }

        public string City { get; set; }

        public int TraceId { get; set; }

        public string Number { get; set; }

        //public string Name { get; set; }

        public string IMEI { get; set; }

        public DateTime CreationDate { get; set; }

        public DateTime RenewDate { get; set; }

        //Payment

        public int PaiementId { get; set; }

        public DateTime PaiementDate { get; set; }
        public bool Payee { get; set; }


        //*************
        public ClientDTO Client { get; set; }
        public PaymentDTO Payment { get; set; }
        public TraceDTO Trace { get; set; }
    }
}
