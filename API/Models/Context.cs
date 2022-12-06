using API.Models;
using Microsoft.EntityFrameworkCore;

namespace api.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Imc> Imc { get; set; }
    }
}