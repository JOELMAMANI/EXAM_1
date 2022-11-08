using exa_1.data.Entity;
using Microsoft.EntityFrameworkCore;

namespace exa_1.data
{
    public class DataContex : DbContext
    {
        public DataContex(DbContextOptions<DataContex> options) : base(options)
        {

        }
        public DbSet<Grade> grades { get; set; }
        public DbSet<Matter> matters { get; set; }
        public DbSet<User> users { get; set; }
    }
}
