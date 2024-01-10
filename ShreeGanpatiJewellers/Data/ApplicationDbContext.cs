using Microsoft.EntityFrameworkCore;
using ShreeGanpatiJewellers.Models;

namespace ShreeGanpatiJewellers.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Category> Categories { get; set; }
    }
}
