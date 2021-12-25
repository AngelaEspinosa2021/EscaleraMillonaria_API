using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Models
{
    public class Player
    {  
        [Key]
        public int IdPlayer { get; set; }

        [Required]
        public string NamePlayer { get; set; }

        public string PlayerAwards { get; set; }

        public string PlayerCategory { get; set; }
        
    }
}
