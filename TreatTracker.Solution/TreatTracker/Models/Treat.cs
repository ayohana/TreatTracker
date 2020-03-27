using System.Collections.Generic;

namespace TreatTracker.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public ICollection<TreatFlavor> Flavors { get; set; }
    public Treat()
    {
      this.Flavors = new HashSet<TreatFlavor>();
    }

  }
}