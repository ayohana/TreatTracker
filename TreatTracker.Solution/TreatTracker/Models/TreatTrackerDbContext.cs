using Microsoft.EntityFrameworkCore;

namespace TreatTracker.Models
{
  public class TreatTrackerContext : DbContext
  {
    public virtual DbSet<Treat> Treats { get; set; }
    public DbSet<Flavor> Flavors { get; set; }
    public DbSet<TreatFlavor> TreatFlavor { get; set; }
    public TreatTrackerContext(DbContextOptions options) : base(options) { }
  }
}