using EntityLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Concrete
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=EMIRHAN\\SQLEXPRESS; database=randomname; Trusted_Connection=True;MultipleActiveResultSets=true; TrustServerCertificate=True;encrypt=false;");
        }
        public DbSet<AnimalName> animalNames { get; set; }
        public DbSet<AnimalType> animalTypes { get; set; }
        public DbSet<ChildName> childNames { get; set; }
        public DbSet<Gender> genders { get; set; }
    }
}