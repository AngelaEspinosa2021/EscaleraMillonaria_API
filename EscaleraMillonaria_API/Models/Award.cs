using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Models
{
    public class Award
    {
        [Key]
        public int IdAward { get; set; }

        [Required]
        public string AwardValue { get; set; }
    }
}
