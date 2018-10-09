using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WelfareDenmark.Model
{
    public class TrainingDbContext : DbContext
    {
        public DbSet<Trainingssession> TrainingsSessions { get; set; }
        public DbSet<Trophies> Trophies { get; set; }
        public DbSet<Trainingspartner> Trainingspartners { get; set; }

        public TrainingDbContext(DbContextOptions<TrainingDbContext> options) : base(options)
        {
                
        }
       
    }
}
