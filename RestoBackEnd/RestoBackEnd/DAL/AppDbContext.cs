using Microsoft.EntityFrameworkCore;
using RestoBackEnd.Models;

namespace RestoBackEnd.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Slider { get; set; }
        public DbSet<PageIntro> PageIntro { get; set; }
        public DbSet<About> About { get; set; }
        public DbSet<AboutCard> AboutCard { get; set; }
        public DbSet<Beef> BeefMeal { get; set; }
        public DbSet<Salmon> SalmonMeal { get; set; }
    }
}
