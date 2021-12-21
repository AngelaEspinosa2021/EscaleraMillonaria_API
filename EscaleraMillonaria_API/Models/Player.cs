using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Models
{
    public class Player
    {
        public int IdPlayer { get; set; }

        public string NamePlayer { get; set; }

        public string PlayerAwards { get; set; }

        public string PlayerCategory { get; set; }

        public List<Question> QuestionsAnsweredByPlayer { get; set; }
    }
}
