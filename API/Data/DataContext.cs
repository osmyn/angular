using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {
    }

    // Add your entity DbSet properties here

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure your entity configurations here

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<AppUser> Users { get; set; }
    
    
}
