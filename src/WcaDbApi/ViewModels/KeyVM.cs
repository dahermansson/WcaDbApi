using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WcaDbApi.ViewModels
{
    public class KeyVM
    {
        [MaxLength(250, ErrorMessage = "Max 250")]
        [EmailAddress(ErrorMessage = "Invalid Email adress")]
        public string Email { get; set; }
        public Guid ApiKey { get; set; }
    }
}
