using Microsoft.EntityFrameworkCore;

namespace TestEfNToN;

public class MyDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
        optionsBuilder.UseSqlServer(@"Data Source=127.0.0.1,1433;Database=n2n-test;User ID=SA;Password=Password1;");

    public DbSet<Tag> Tags { get; set; }
    public DbSet<TimeSlot> TimeSlots { get; set; }
}