using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.Models
{
    public class Payment
    {
        [Key]
        public int PaiementId { get; set; }
        public DateTime PaiementDate { get; set; }
        public bool Payee { get; set; }

        [ForeignKey("Trace")]
        public int TraceId { get; set; }
        public Trace Trace { get; set; }
    }
}
