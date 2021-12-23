using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Models.Dto
{
    public class AwardDto
    {
        public int IdAward { get; set; }

        public string AwardValue { get; set; }

        public int QuestionPosition { get; set; }

    }
}
