using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.DTO
{
    public class ClientDTO
    {
        [Required]
        public int ClientId { get; set; }
        [Required]
        public string Login { get; set; }
        [Required]
        [StringLength(8)]
        public string PhoneNumber { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string City { get; set; }
    }
}
