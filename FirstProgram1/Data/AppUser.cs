using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram1.Data
{
    public class AppUser : IdentityUser
    {
        [Required]
        public string? Name { get; set; }
        [ForeignKey(nameof(ProgramId))]
        public int? ProgramId { get; set; }
        public virtual DomainLayer.Models.Program Program { get; set; }
    }
}
