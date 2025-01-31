using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram1.Data
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Program { get; set; }
    }
}
