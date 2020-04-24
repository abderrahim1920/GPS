using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPS.Models
{
    public class Client
    {
        [Key]
        public int ClientId { get; set; }
        public string Login { get; set; }
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
