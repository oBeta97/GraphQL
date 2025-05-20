using GraphQL.entities;
using Microsoft.EntityFrameworkCore;

namespace GraphQL.dbContext;

public class AppDbContext : DbContext
{
    // Costruttore che passa le opzioni al base DbContext
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

    // DbSet per ogni entità del modello
    public DbSet<User> Users { get; set; }
    public DbSet<Role> Roles { get; set; }
    public DbSet<BankData> BankDatas { get; set; }
    public DbSet<BankDetail> BankDetails { get; set; }

    // Opzionale: Configurazione delle relazioni via Fluent API
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        // (Possiamo aggiungere configurazioni fluenti qui se necessario)
    }
}

