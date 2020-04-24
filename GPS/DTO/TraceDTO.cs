using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.DTO
{
    public class TraceDTO
    {
        [Required]
        public int TraceId { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(15)]
        public string IMEI { get; set; }
        [Required]
        public DateTime CreationDate { get; set; }
        [Required]
        public DateTime RenewDate { get; set; }
        public int ClientId { get; set; }
    }
}
