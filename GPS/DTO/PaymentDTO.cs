using GPS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.DTO
{
    public class PaymentDTO
    {
        [Required]
        public int PaiementId { get; set; }
        [Required]
        public DateTime PaiementDate { get; set; }
        public bool Payee { get; set; }
        [Required]
        public int TraceId { get; set; }
        public TraceDTO Trace { get; set; }
    }
}
