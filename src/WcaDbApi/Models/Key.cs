using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WcaDbApi.Models
{
    public class Key
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string Email { get; set; }
        [Required]
        public Guid ApiKey { get; set; }
        public bool BannedEmail { get; set; }
        public bool BannedKey { get; set; }
    }
}
