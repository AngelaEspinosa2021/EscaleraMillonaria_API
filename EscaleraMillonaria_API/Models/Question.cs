using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Models
{
    public class Question
    {   
        [Key]
        public int IdQuestion { get; set; }

        [Required]
        public string QuestionStatement { get; set; }

        [Required]
        public string OptionOne { get; set; }

        [Required]
        public string OptionTwo { get; set; }

        [Required]
        public string OptionThree { get; set; }

        [Required]
        public string OptionFour { get; set; }

        [Required]
        public string Answer { get; set; }

        [ForeignKey("Category")]
        public int IdCategory { get; set; }


    }
}
