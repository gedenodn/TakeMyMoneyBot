using DomainLayer.Configuration;
using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;

public class MoneyBotDbContext : DbContext
{
    public MoneyBotDbContext(DbContextOptions<MoneyBotDbContext> options) : base(options)
    {
    }

    public DbSet<ApplicationUser> ApplicationUsers { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Transaction> Transactions { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
        modelBuilder.ApplyConfiguration(new CategoryConfiguration());
        modelBuilder.ApplyConfiguration(new TransactionConfiguration());
    }
}
