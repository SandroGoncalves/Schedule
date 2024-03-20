using Gendar.Entity;
using Microsoft.EntityFrameworkCore;

namespace Gendar.Context
{
    public class SqlServerContext : DbContext
    {
        public SqlServerContext(DbContextOptions<SqlServerContext> options) : base(options) { }
        public virtual DbSet<Staff> Staff { get; set; }
    }
}
