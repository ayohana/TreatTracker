using System.Collections.Generic;

namespace TreatTracker.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }
    public virtual ApplicationUser User { get; set; }
    public ICollection<TreatFlavor> Flavors { get; set; }
    public Treat()
    {
      this.Flavors = new HashSet<TreatFlavor>();
    }

  }
}