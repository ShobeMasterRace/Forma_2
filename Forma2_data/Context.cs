using Microsoft.EntityFrameworkCore;
using System;

namespace Forma2_Data.Models
{
    public class Context : DbContext
    {
        public Context() : base()
        {


        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB; Database=Korisnici; Trusted_Connection=true");

        }

        public DbSet<Models.AutoModel> Automobili { get; set; }
        public DbSet<Models.MotorModel> Motori { get; set; }
    }
}
