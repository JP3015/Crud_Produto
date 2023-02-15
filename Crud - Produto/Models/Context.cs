using Microsoft.EntityFrameworkCore;

namespace Crud___Produto.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {

        }
        public DbSet<Produto> Produto { get; set; } 
    }
}
