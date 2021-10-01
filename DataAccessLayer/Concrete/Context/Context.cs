using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete.Context
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-RQ8KHFA;database=CoreCvDB;integrated security=true;");
        }

        public DbSet<Award> Awards { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Ability> Abilities { get; set; }
        public DbSet<EducationLife> EducationLives { get; set; }
        public DbSet<Experience> Experiences { get; set; }
        public DbSet<MyHobby> MyHobbies { get; set; }
    }
}
