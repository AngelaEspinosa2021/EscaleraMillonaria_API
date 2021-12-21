using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Models
{
    public class Question
    {
        public int IdQuestion { get; set; }

        public string QuestionStatement { get; set; }

        public string OptionOne { get; set; }

        public string OptionTwo { get; set; }

        public string OptionThree { get; set; }

        public string OptionFour { get; set; }


    }
}
