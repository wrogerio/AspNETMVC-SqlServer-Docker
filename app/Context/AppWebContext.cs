using app.Models;
using Microsoft.EntityFrameworkCore;

namespace app.Context
{
    public class AppWebContext : DbContext
    {
        public AppWebContext(DbContextOptions<AppWebContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Clientes");

            modelBuilder.Entity<Cliente>().HasKey(c => c.Id);
            modelBuilder.Entity<Cliente>().Property(c => c.Nome)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(c => c.Sobrenome)
            .HasMaxLength(100)
            .IsRequired();

            modelBuilder.Entity<Cliente>().Property(c => c.Idade)
                .IsRequired();

            modelBuilder.Entity<Cliente>().Property(c => c.Endereco)
                .HasMaxLength(100)
                .IsRequired();
        }
    }
}