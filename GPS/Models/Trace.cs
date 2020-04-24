using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.Models
{
    public class Trace
    {
        [Key]
        public int TraceId { get; set; }
        public string Number { get; set; }
        public string Name { get; set; }
        public string IMEI { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime RenewDate { get; set; }

        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
