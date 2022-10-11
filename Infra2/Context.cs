using Domain.Entidades;
using Microsoft.EntityFrameworkCore;


namespace Infra2
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }

        public DbSet<Conta> Contas { get; set; }

    }

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    modelBuilder.ApplyConfigurationsFromAssembly(typeof(Context).Assembly);
    //} 
}
