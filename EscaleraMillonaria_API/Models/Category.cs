using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Models
{
    public class Category
    {
        [Key]
        public int IdCategory { get; set; }

        [Required]
        public string CategoryName { get; set; }        

    }
}
