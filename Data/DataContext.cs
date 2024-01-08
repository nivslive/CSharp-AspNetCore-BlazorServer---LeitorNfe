using Microsoft.EntityFrameworkCore;
using LeitorNfe.Core.Models;
using System.Xml.Serialization;
using Microsoft.EntityFrameworkCore.SqlServer;
namespace LeitorNfe.Data;
public class DataContext : DbContext
{
    public DbSet<NFe> NFes {get; set;}
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.Entity<NFe>();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.EnableSensitiveDataLogging();
        // other configurations...
    }

}
