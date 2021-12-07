using Microsoft.EntityFrameworkCore;
using ReactJsWithWebApiCSharp.Models;

namespace ReactJsWithWebApiCSharp.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Produto> Produtos { get; set; }
    }
}
