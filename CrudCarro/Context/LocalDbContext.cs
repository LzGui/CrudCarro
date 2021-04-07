using Microsoft.EntityFrameworkCore;
using CrudCarro.Entities;

namespace CrudCarro.Context
{
    public class LocalDbContext : DbContext
    {
        public LocalDbContext(DbContextOptions<LocalDbContext> opt) : base(opt)
        {

        }

        public DbSet<Carros> carro { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }


    }
}