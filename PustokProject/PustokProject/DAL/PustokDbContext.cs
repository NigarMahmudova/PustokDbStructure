using Microsoft.EntityFrameworkCore;
using PustokProject.Entities;

namespace PustokProject.DAL
{
    public class PustokDbContext:DbContext
    {
        public PustokDbContext(DbContextOptions<PustokDbContext>options):base(options)
        {

        }
        public DbSet<Slider> HomeSlider { get; set; }
        public DbSet<Button> Buttons { get; set; }
        public DbSet<Feature> Features { get; set; }
    }
}
