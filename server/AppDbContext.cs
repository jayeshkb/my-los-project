using Microsoft.EntityFrameworkCore;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

    public DbSet<Vehicle> Vehicles { get; set; }
}

public class Vehicle
{
    public int Id { get; set; }
    public string Vin { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
}
