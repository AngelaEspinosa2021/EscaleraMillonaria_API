﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Models
{
    public class Category
    {
        public int IdCategory { get; set; }

        public string CategoryName { get; set }

        public List<Question> Questions { get; set; }
    }
}