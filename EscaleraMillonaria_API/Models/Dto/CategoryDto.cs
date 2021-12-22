using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Models.Dto
{
    public class CategoryDto
    {
        public int IdCategory { get; set; }

        public string CategoryName { get; set; }

        public List<Question> Questions { get; set; }

        public List<Award> Awards { get; set; }

    }
}
