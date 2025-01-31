using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainLayer.Models
{
    public class Program
    {
        [Key]
        public int ProgramId { get; set; }
        public string ProgramName { get; set; }
        public string Description { get; set; }
        public string Department { get; set; }
    }
}
