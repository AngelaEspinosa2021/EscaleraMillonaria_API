using EscaleraMillonaria_API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscaleraMillonaria_API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {

        }

        public DbSet<Question> Questions { get; set; }

        public DbSet<Award> Awards { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Player> Players { get; set; }
    }
}
