using Microsoft.EntityFrameworkCore;
using ProductMvc.Models;

namespace ProductMvc
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Produk> Produk { get; set; }
    }
}